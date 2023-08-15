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
    /// Interaction logic for FinalScore.xaml
    /// </summary>
    public partial class FinalScore : Window
    {

        


        public FinalScore()
        {
            InitializeComponent();
           

            txtPlayerScore.Text = PlayerData.score.ToString();  //takes player score and converts to string
           

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            this.Close();  

            Genre NewCatWin = new Genre();  //creates category window
            NewCatWin.Show();   //shows category window
            


        }

        private void btnGenres_Click(object sender, RoutedEventArgs e)
        {
            PlayerData.score = 0; 

            Genre NewCatWin = new Genre();  //creates Category window

            NewCatWin.Show();    //shows Category Window
            this.Close();       //hides the mainwindow

            



        }
    }



   }

    


