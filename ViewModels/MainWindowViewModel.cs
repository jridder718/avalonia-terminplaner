using avalonia_terminplaner.Models;

namespace avalonia_terminplaner.ViewModels;

using System.Collections.ObjectModel;

public class MainWindowViewModel {
    public ObservableCollection<Appointment> Appointments { get; set; } = [];
}
