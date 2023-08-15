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
    /// Interaction logic for WindowGH.xaml
    /// </summary>
    public partial class WindowGH : Window
    {
        // create a new list of integers called question numbers
        // this interger will hold how many questions we have for this quiz and we will shuffle this inside the start game function
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        int qNum = 0;
        int i;
        
        public WindowGH()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();

            



        }
        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            // this is the check answer function, this function is linked to all buttons
            // when either of the buttons will be pressed, it will check them

            Button senderButton = sender as Button; // first check which button sent this event and link it to a local button inside of this event

            // in the if statement below is true, it will add one to score
            if (senderButton.Tag.ToString() == "1")
            {
                PlayerData.score++;
            }

            // if the qnum is less than 0 then we will reset the qnum integer to 0
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                // if the qnum is greater than 0 then we will add 1 to the qnum 
                qNum++;
            }

           

            // run the next question function
            NextQuestion();

        }

        private void RestartGame()
        {
            // restart game function will load all of the default values for this game
            PlayerData.score = 0; // set score to 0
            qNum = -1; // set qnum to -1
            i = 0; // set i to 0
            StartGame(); // run the start game function
        }

        private void NextQuestion()
        {
            // this function will check which question to show next and it will have all of the question and answer definitions

            // in the if statement below it will checking if the qnum integer is less than the total number of questions if it then we will set the value of i to the value of qnum

            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                FinalScore NewScoreWin = new FinalScore();  //creates Score window

                   
                NewScoreWin.Show();    //shows Category Window
                this.Close();       //hides the mainwindow

                
            }

            // below we are running a foreach loop where will check for each button inside of the canvas and when we find them we will set their tag to 0 and background to crimson
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.Crimson;
            }


           


            // this switch statement will check what value is inside of i integer and show the questions based on that value

            switch (i)
            {
                case 1:

                    txtQuestion2.Text = "Who burned ancient athens?"; // this the question for the quiz

                    ans5.Content = "Xerxes"; // each of the buttons can have their own answers in this game
                    ans6.Content = "Solon";
                    ans7.Content = "Socrates";
                    ans8.Content = "Themistocles";

                    ans5.Tag = "1"; // here we tell the program which one of the answers above is the right answer by adding the 1 inside of the tag for the button. 
                                    // in this example we adding 1 inside of ans2 or button 2
                                    // so when the button is clicked the game will know which is the correct answer and it add 1 to the score for the game




                    break; // when this condition is met the program will break the switch statement here and wait for the next one
                           // rest of the condition will follow the same principle as this one

                case 2:

                    txtQuestion2.Text = "In Greek mythology,what did the golden arrow of Eros make people do?";

                    ans5.Content = "Fall in love";
                    ans6.Content = "Sing a song";
                    ans7.Content = "Fight with each other";
                    ans8.Content = "Cry";

                    ans5.Tag = "1";



                    break;

                case 3:

                    txtQuestion2.Text = "Which Persian king did the Greeks defeat at the Battle of Marathon?";

                    ans5.Content = "Cyrus";
                    ans6.Content = "Xerxes";
                    ans7.Content = "Darius";
                    ans8.Content = "Mithridates";

                    ans7.Tag = "1";



                    break;

                case 4:

                    txtQuestion2.Text = "Who was Alexander the Great’s teacher?";

                    ans5.Content = "Archimedes";
                    ans6.Content = "Pythagoras";
                    ans7.Content = "Aristotle";
                    ans8.Content = "Plato";

                    ans7.Tag = "1";



                    break;

                case 5:

                    txtQuestion2.Text = "Who is the renowned chronicler of the Peloponnesian War?";

                    ans5.Content = "Pliny";
                    ans6.Content = "Thucydides";
                    ans7.Content = "Xenophon";
                    ans8.Content = "Herodotus";

                    ans6.Tag = "1";



                    break;
                case 6:

                    txtQuestion2.Text = "Alexander the Great was from?..";

                    ans5.Content = "Macedonia";
                    ans6.Content = "Egypt";
                    ans7.Content = "Greece";
                    ans8.Content = "Gaul";

                    ans5.Tag = "1";



                    break;
                case 7:

                    txtQuestion2.Text = "Which Greek city is often called the birthplace of democracy?";

                    ans5.Content = "Athens";
                    ans6.Content = "Corinth";
                    ans7.Content = "Sparta";
                    ans8.Content = "Delphi";

                    ans5.Tag = "1";



                    break;
                case 8:

                    txtQuestion2.Text = "How does history tell us Socrates died?";

                    ans5.Content = "Hanging";
                    ans6.Content = "Old age";
                    ans7.Content = "Beheading";
                    ans8.Content = "Poison";

                    ans8.Tag = "1";



                    break;
                case 9:

                    txtQuestion2.Text = "Who was the enemy of Athens in the Peloponnesian War?";

                    ans5.Content = "Syracuse";
                    ans6.Content = "Sparta";
                    ans7.Content = "Thebes";
                    ans8.Content = "Egypt";

                    ans6.Tag = "1";



                    break;

                case 10:

                    txtQuestion2.Text = "Who wrote the Odyessy?";

                    ans5.Content = "Homer";
                    ans6.Content = "Odysseus";
                    ans7.Content = "Athena";
                    ans8.Content = "Achillies";

                    ans5.Tag = "1";



                    break;
            }
        }


        private void StartGame()
        {
            PlayerData.score = 0;
            // this is the start game function
            // inside of this function we will randomise the questions list and save it back into the list 

            // create a new randomlist variable and use the line below to randomise the order of the content
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            // save the random list to the question numbers list again
            questionNumbers = randomList;

            // empty the question order label on the canvas
            questionOrder.Content = null;

            // run a for loop to add the value which will display the randomised list to the display so we can see how the list has been ramdomised
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }

        }

 
    }
}


    

    

