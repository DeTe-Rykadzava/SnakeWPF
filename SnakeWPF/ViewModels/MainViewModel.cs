using System.Windows;
using System.Windows.Input;
using SnakeWPF.Core;
using SnakeWPF.Views;

namespace SnakeWPF.ViewModels;

public class MainViewModel
{
    public ICommand StartGameCommand { get; }
    public ICommand ExitCommand { get; }

    public MainViewModel()
    {
        // Initialize your commands
        StartGameCommand = new RelayCommand(StartGame);
        ExitCommand = new RelayCommand(Exit);
    }

    private void StartGame()
    {
        // Implement the logic to start the game here

        // Create and show the game window
        GameWindow gameWindow = new GameWindow();
        gameWindow.Show();

        // Close the current main menu window
        Application.Current.MainWindow.Close();
    }

    private void Exit()
    {
        // Implement the logic to exit the application here
        Application.Current.Shutdown();
    }
}