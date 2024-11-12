using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
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
        // Hier die Eingabewerte lesen
        var title = TitleTextBox.Text;
        var description = DescriptionTextBox.Text;
        var date = DatePicker.SelectedDate?.DateTime ?? DateTime.Now;
        var duration = TimeSpan.FromHours(double.TryParse(DurationTextBox.Text, out double hours) ? hours : 1);

        // Ein neues Appointment erstellen
        NewAppointment = new Appointment
        {
            Title = title,
            Description = description,
            Date = date,
            Time = duration
        };

        // Fenster schlieﬂen
        Close();
    }

    private void OnCancelButtonClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}