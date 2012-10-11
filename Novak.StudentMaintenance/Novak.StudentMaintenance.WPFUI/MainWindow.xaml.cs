using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Novak.StudentMaintenance.BL;

namespace Novak.StudentMaintenance.WPFUI
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

        private void btnMakePerson_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            CStudent oStudent = new CStudent();

            oStudent.Firstname = txtFirstname.Text;
            oStudent.Lastname = txtLastname.Text;

            lblFullname.Content = oStudent.Fullname;

            oStudent = null;
        }
    }
}
