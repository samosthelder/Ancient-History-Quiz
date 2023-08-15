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

namespace Ancient_History_Quiz
{
    /// <summary>
    /// Interaction logic for Genre.xaml
    /// </summary>
    public partial class Genre : Window
    {
        public Genre()
        {
            InitializeComponent();
        }

     
     
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

            WindowRH windowRoman = new WindowRH();  //creates window for Roman History
           
            WindowGH windowGreek = new WindowGH();  //creates window for Greek History

            if(radioBtnRH.IsChecked == true)   //checks radio button for RH is checked
            {
                PlayerData.score = 0;
                windowRoman.Show();  //shows RH window
                                    //shows RH window
                this.Close();            
            }

            else if (radioBtnGH.IsChecked == true)   //checks radio button for GH is checked
            {
                PlayerData.score = 0;
                windowGreek.Show();        //shows GH window
                this.Close();           //shows GH window
            }
            else 
            {
                MessageBox.Show("must pick a genre");   //message for leaving options without input
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
           
            
        }

        private void radioBtnGH_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioBtnGH = (RadioButton)sender;
            
            
        }

        private void radioBtnRH_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioBtnRH = (RadioButton)sender;
          
        }
    
    }
}
