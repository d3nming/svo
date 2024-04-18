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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }
        Model1 app = new Model1();
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int? d = Convert.ToInt32(Day.Text);
            int? dd = Convert.ToInt32(Day.Text);
            DateTime datepick = DatePick.SelectedDate ?? DateTime.Now;
            Activity newItem = new Activity
            {
                NameEvent = NameEvent.Text,
                DateStart = datepick,
                Day = d,
                Days = dd
            };
            app.Activity.Add(newItem);
            app.SaveChanges();
            this.Close();
        }
    }
}
