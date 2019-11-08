using System;
using System.Collections.Generic;
using System.Data.Common;
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
using Lab5_WPF.Classes;

namespace Lab5_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // ListShow.ItemsSource = PhoneBook.Book;
        }

        private void IndividualAdd(object sender, RoutedEventArgs e)
        {
            var individualAddWindow = new IndividualAdd();
            individualAddWindow.Show();
        }

        private void CompanyAdd(object sender, RoutedEventArgs e)
        {
            var companyAdd= new CompanyAdd();
            companyAdd.Show();
        }

        private void Exit_OnClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        
        private void ListUpdate()
        {
            ListShow.Text = "Records :\n";
            foreach (var record in PhoneBook.Book)
            {
                ListShow.Text += record;
            }
        }

        private void MainWindow_OnActivated(object sender, EventArgs e)
        {
            ListUpdate();
        }
    }
}
