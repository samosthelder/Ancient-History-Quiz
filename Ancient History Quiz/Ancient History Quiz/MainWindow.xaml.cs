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

namespace Ancient_History_Quiz
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

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            //varibles for player name and password
            string userName = txtPlayer.Text;
            string userPass = pswdAdd.Password;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPass))  // makes sure player name and password is not empty
            {
                MessageBox.Show("You must enter a user name and password!");         // alerts user to enter a user name and password
            }

            else if (userName.Length < 5)                                         // checks userName is at least 5 characters or more
            {
                MessageBox.Show("Name must be 5 characters or more");                // alerts user to say name must be 5 characters or more
            }

            else if (userPass.Length < 5)                                          // checks userPass is at least 5 characters
            {
                MessageBox.Show("Password must be 5 characters or more");           // checks userPass is at least 5 characters or more
            }
            else if (userName == userPass)                                      // checks userName and userPass do not match
            {
                MessageBox.Show("User name and password cant match!");           //message alerting user that name and password match
            }

            else 
            {

                MessageBox.Show("Hi " + userName + " Welcome to My quiz");

                Genre NewCatWin = new Genre();  //creates Category window

                NewCatWin.Owner = this; // sets the mainwindow as owner to the Category Window

                this.Hide();

                NewCatWin.Show();    //shows Category Window
                                                              
            }

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("are you sure you wish to exit the quiz, last chance?",     //displays message box to ensure correct choice is made
           "my app", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
            {
                e.Cancel = true;  //cancels event
            }
        }

       

       
    }
}
