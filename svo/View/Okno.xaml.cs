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
using System.Windows.Shapes;

namespace svo.View
{
    /// <summary>
    /// Логика взаимодействия для Okno.xaml
    /// </summary>
    public partial class Okno : Window
    {
        Model1 app = new Model1();
        List<Activity> activities;
        public Okno()
        {
            InitializeComponent();
            bib();
        }
        public void bib()
        {
            activities = app.Activity.ToList();
            ProductList.ItemsSource = activities;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Add s = new Add();
            s.ShowDialog();
            ProductList.ItemsSource = null;
            bib();
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int Id = Convert.ToInt32(btn.Tag.ToString());
            var akt = app.Activity.FirstOrDefault(a => a.Id == Id);
            app.Activity.Remove(akt);
            app.SaveChanges();
            MessageBox.Show("Delete");
            bib();
        }
    }
}
