using Avalonia.Controls;
using Avalonia.Interactivity;
using avalonia_terminplaner.Models;
using System;

namespace avalonia_terminplaner;

public partial class AppointmentDialog : Window
{
    public Appointment NewAppointment { get; private set; }

    public AppointmentDialog()
    {
        InitializeComponent();
    }

    private void OnSaveButtonClick(object sender, RoutedEventArgs e)
    {
        NewAppointment = new()
        {
            Title = TitleTextBox.Text,
            Description = DescriptionTextBox.Text,
            Date = DatePicker.SelectedDate?.DateTime ?? DateTime.Now,
            Time = TimeSpan.FromHours(double.TryParse(DurationTextBox.Text, out double hours) ? hours : 1)
        };

        Close();
    }

    private void OnCancelButtonClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}