using System;
using System.Collections.ObjectModel;
using System.Windows;
using ICommandLesson.Core;
using ICommandLesson.MVVM.ViewModel.Commands;

namespace ICommandLesson.MVVM.ViewModel;

public class MainWindowViewModel
{
    // public string MessageText { get; set; }
    public MessageCommand DisplayMessageCommand { get; private set; }

    public ObservableCollection<string> MyMessages { get; private set; }
    public RelayCommand MessageBoxCommand { get; private set; }
    public RelayCommand ConsoleLogCommand { get; private set; }
    public MainWindowViewModel()
    {
        DisplayMessageCommand = new MessageCommand(ShowMessage);
        MyMessages = new ObservableCollection<string>()
        {
            "Hello World!",
            "My name is Joe",
            "I love learning commands",
            "I'm a message box!",
            "I'm a console!"
        };

        MessageBoxCommand = new RelayCommand(DisplayInMessageBox, MessageBoxCanUse);
        ConsoleLogCommand = new RelayCommand(DisplayInConsole, ConsoleCanUse);
    }

    public void DisplayInMessageBox(object? message)
    {
        MessageBox.Show((string)message);
    }
    public void DisplayInConsole(object? message)
    {
        Console.WriteLine((string)message);
    }
    
    public bool MessageBoxCanUse(object? message)
    {
        if ((string)message == "I'm a console!")
        {
            return false;
        }

        return true;
    }

    public bool ConsoleCanUse(object? message)
    {
        if ((string)message == "I'm a message box!")
        {
            return false;
        }

        return true;
    }

    public void ShowMessage(string message)
    {
        MessageBox.Show(message);
    }
}