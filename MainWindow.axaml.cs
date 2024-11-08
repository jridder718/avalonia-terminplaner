using avalonia_terminplaner.ViewModels;
using Avalonia.Controls;

namespace avalonia_terminplaner;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
