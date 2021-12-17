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

namespace _2_events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string firstname = Firstname.Text;
            string lastname = Lastname.Text;

            if (firstname == "Введите свое имя" ||
                lastname == "Введите свою фамилию")
            {
                MessageBox.Show("Вы не заполнили поля!");
            }
            else
            {
                MessageBox.Show("Ваше имя: " + lastname + " " + firstname);

                Firstname.Text = "Введите свое имя";
                Lastname.Text = "Введите свою фамилию";
            }

        }

        private void Firstname_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Firstname.Text == "Введите свое имя")
            {
                Firstname.Text = "";
            }
        }

        private void Firstname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Firstname.Text == "")
            {
                Firstname.Text = "Введите свое имя";
            }
        }

        private void Lastname_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Lastname.Text == "Введите свою фамилию")
            {
                Lastname.Text = "";
            }
        }

        private void Lastname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Lastname.Text == "")
            {
                Lastname.Text = "Введите свою фамилию";
            }
        }
    }
}
