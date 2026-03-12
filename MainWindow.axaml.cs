using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Animals.Models;

namespace Animals;

public partial class MainWindow : Window
{
    private readonly ObservableCollection<Animal> _animals = new();

    public MainWindow()
    {
        InitializeComponent();
        AnimalsDataGrid.ItemsSource = _animals;
    }

    private void AddAnimalButton_Click(object? sender, RoutedEventArgs e)
    {
        var name = NameTextBox.Text?.Trim() ?? string.Empty;
        if (string.IsNullOrEmpty(name))
            return;

        var gender = (GenderComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? string.Empty;
        var dob = DateOfBirthPicker.SelectedDate;

        var animal = new Animal
        {
            Name = name,
            Gender = gender,
            DateOfBirth = dob
        };

        _animals.Add(animal);

        // Clear input fields after adding
        NameTextBox.Text = string.Empty;
        GenderComboBox.SelectedIndex = -1;
        DateOfBirthPicker.SelectedDate = null;
    }
}
