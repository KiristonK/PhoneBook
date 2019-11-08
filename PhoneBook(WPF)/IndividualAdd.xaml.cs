using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Lab5_WPF.Classes;
using System.Linq;
using System.Linq.Expressions;

namespace Lab5_WPF
{
    /// <summary>
    /// Interaction logic for IndividualAdd.xaml
    /// </summary>
    public partial class IndividualAdd : Window
    {
        public IndividualAdd() 
        {
            InitializeComponent();
            PreviewChange();
        }

        private void Exit_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddRecord(object sender, RoutedEventArgs e)
        {
            PreviewChange();
            if (!PhoneCheck()) return;
            PhoneBook.Book.Add(new Individual(FirstName.Text, LastName.Text, PhoneNumber.Text, Address.Text));
            MessageBox.Show("Record added !");
            Close();
        }

        private void FirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            LastName.Focus();
            PreviewChange();
        }

        private void LastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            PhoneNumber.Focus();
            PreviewChange();
        }

        private void PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            if (!PhoneCheck()) return;
            PreviewChange();
            Address.Focus();
        }

        private void Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            PreviewChange();
            AddRecordButton.Focus();
        }
        private void PreviewChange(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            PreviewChange();
        }

        private bool PhoneCheck()
        {
            if (PhoneNumber.Text.Length != 9) { MessageBox.Show("Phone must be 9 characters long !", "Error 0"); return false; }
            if (!int.TryParse(PhoneNumber.Text, out _))
            { MessageBox.Show("Phone must contain only numbers !", "Error 1"); return false; }
            if (PhoneBook.Book?.Find(f => f.PhoneNumber == int.Parse(PhoneNumber.Text)) == null) return true;
            MessageBox.Show("Phone number is already exists !\nPlease, enter another phone number.", "Error 2"); return false;
        }

        private void PreviewChange()
        {
            RecordPreview.Text = $@"First Name: {FirstName.Text}
Last Name: {LastName.Text}
Phone number: {PhoneNumber.Text}
Address: {Address.Text}";
        }
    }
}
