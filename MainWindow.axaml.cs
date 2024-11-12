using avalonia_terminplaner.ViewModels;
using Avalonia.Controls;
using System;
using Avalonia.Interactivity;
using avalonia_terminplaner.Models;

namespace avalonia_terminplaner;

public partial class MainWindow : Window {
    private readonly MainWindowViewModel _viewModel;

    public MainWindow() {
        InitializeComponent();
        _viewModel = new MainWindowViewModel();
        DataContext = _viewModel;

        AddAppointment("Kundenbesuch im Office", "Bitte denkt daran, einen Parkplatz freizuhalten, damit der Kunde sich drauf stellen kann.", DateTime.Now, TimeSpan.FromDays(1));
        AddAppointment("Arbeitszeitbetrug", "Nicht arbeiten", DateTime.Now, TimeSpan.FromDays(1));
    }

    private void Add_Appointment_Button_Click(object? sender, RoutedEventArgs e)
    {
        AddAppointment("Titel", "Beschreibung", DateTime.Now, TimeSpan.FromDays(1));
    }

    private void AddAppointment(string title, string description, DateTime date, TimeSpan time)
    {
        _viewModel.Appointments.Add(new()
        {
            Title = title,
            Description = description,
            Date = date,
            Time = time
        });
    }

    private void Delete_Appointment_Button_Click(object? sender, RoutedEventArgs e)
    {
        var button = sender as Button;

        if (button?.DataContext is Appointment appointment)
        {
            _viewModel.Appointments.Remove(appointment);
        }
    }
}
