using System;
using System.Windows.Input;

namespace SnakeWPF.Core;

public class RelayCommand : ICommand
{
    private Action execute;

    public RelayCommand(Action execute)
    {
        this.execute = execute;
    }

    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        execute();
    }
}