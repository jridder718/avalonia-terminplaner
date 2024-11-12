using avalonia_terminplaner.Models;

namespace avalonia_terminplaner.ViewModels;

using System;
using System.Collections.ObjectModel;

public class MainWindowViewModel {
    public ObservableCollection<Appointment> Appointments { get; set; } = [];
    public static string TodayWeekday => DateTime.Now.ToString("dddd");
    public static string TodayDate => DateTime.Now.ToString("dd.MM.yyyy");
}
