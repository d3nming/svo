using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace svo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        if (Regex.IsMatch(Event.Text, @"\d") || Event.Text.Contains("0"))
        {
        MessageBox.Show("Пожалуйста, введите корректное направление без цифр.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        return;
        }
        DateTime selectedDate = Date.SelectedDate.GetValueOrDefault();
        if (selectedDate < DateTime.Today)
        {    
        MessageBox.Show("Выбранная дата рождения не может быть в прошлом.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        Date.SelectedDate = DateTime.Today;
        return;
        --
        private bool IsFullNameValid(string fullName)
        {
        foreach (char c in fullName)
        {
        if (!char.IsWhiteSpace(c) && !char.IsLetter(c))
        {
            return false;
        }
        }
        string[] parts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return parts.Length == 3;
         if (!IsFullNameValid(idFio.Text))
 {
     MessageBox.Show("Пожалуйста, введите корректное ФИО из трех частей без цифр и спецсимволов.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
     return;
 }
 if (!IsPasswordValid(pass.Password))
{
    MessageBox.Show("Пароль не соответствует требованиям.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
    return;
}            
if (!Regex.IsMatch(idEmail.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
{
    MessageBox.Show("Пожалуйста, введите корректный email.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
    return;
}   
private bool IsPasswordValid(string password)
    {           
        var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,}$");
        return regex.IsMatch(password);
    }
    }
}
