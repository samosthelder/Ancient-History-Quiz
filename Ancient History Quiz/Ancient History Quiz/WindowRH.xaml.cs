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
    /// Interaction logic for WindowTest.xaml
    /// </summary>
    public partial class WindowRH : Window
    {
       

        // create a new list of integers called question numbers
        // this interger will hold how many questions we have for this quiz and we will shuffle this inside the start game function
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // create 3 more integers called qNum that will control which question shows on the screen, i and score
        int qNum = 0;
        int i;
        

        public WindowRH()
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
                // if the qnum is greater than 0 then we will add 1 to the qnum integer
                qNum++;
            }

          

            // run the next question function
            NextQuestion();

        }

        private void RestartGame()
        {
            // restart game function will load all of the default values for this game
            PlayerData.score = 0; // set roman history score to 0
            

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
                // if we have done below the number of questions we have available then it will show score window

                FinalScore NewScoreWin = new FinalScore();  //creates Score window


               

                NewScoreWin.Show();    //shows Category Window

                this.Close();       //hides the mainwindow
            }

            // below we are running a foreach loop where will check for each button inside of the canvas and when we find them we will set their tag to 0 
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }



            // this switch statement will check what value is inside of i integer and show the questions based on that value

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Who said Veni Vidi Vici?"; // Questions for quiz

                    ans1.Content = "Julius Caesar"; // each of the buttons can have their own answers in this game
                    ans2.Content = "Pompey Magnus";
                    ans3.Content = "Mark Anthony";
                    ans4.Content = "Octavian";

                    ans1.Tag = "1"; // here we tell the program which one of the answers above is the right answer by adding the 1 inside of the tag for the button. 
                                    // in this example we adding 1 inside of ans1
                                    // so when the button is clicked the game will know which is the correct answer and it add 1 to the score for the game

                    


                    break; // when this condition is met the program will break the switch statement here and wait for the next one
                           // rest of the condition will follow the same principle as this one

                case 2:

                    txtQuestion.Text = "Who were the Punnic Wars fought with?";

                    ans1.Content = "Egypt";
                    ans2.Content = "Visigoths";
                    ans3.Content = "Carthage";
                    ans4.Content = "Hunns";

                    ans3.Tag = "1";

                   

                    break;

                case 3:

                    txtQuestion.Text = "Who was the main conspirator in the assasination of Julius Caesar";

                    ans1.Content = "Cicero";
                    ans2.Content = "Augustus";
                    ans3.Content = "Marce Leipdus";
                    ans4.Content = "Marcus Brutus";

                    ans4.Tag = "1";

                 

                    break;

                case 4:

                    txtQuestion.Text = "When is Rome said to have been founded?";

                    ans1.Content = "20BC";
                    ans2.Content = "18AD";
                    ans3.Content = "753BC";
                    ans4.Content = "100BC";

                    ans3.Tag = "1";

                 

                    break;

                case 5:

                    txtQuestion.Text = "Who was said to be the mythical founders of Rome?";

                    ans1.Content = "Jack & Jill";
                    ans2.Content = "Romulus & Remus";
                    ans3.Content = "Plato";
                    ans4.Content = "Julius Caesar";

                    ans2.Tag = "1";

                 

                    break;
                case 6:

                    txtQuestion.Text = "Who was first Emperor of Rome?";

                    ans1.Content = "Mark Anthony";
                    ans2.Content = "Julius Caesar";
                    ans3.Content = "Augustus";
                    ans4.Content = "Pompey";

                    ans3.Tag = "1";

                   

                    break;
                case 7:

                    txtQuestion.Text = "Ancient Rome was built on how many hills?";

                    ans1.Content = "7";
                    ans2.Content = "2";
                    ans3.Content = "3";
                    ans4.Content = "4";

                    ans1.Tag = "1";

                   

                    break;
                case 8:

                    txtQuestion.Text = "Which ancient Roman city was destroyed after the eruption of Mount Vesuvius?";

                    ans1.Content = "Pompei";
                    ans2.Content = "Amphissa";
                    ans3.Content = "Londinium";
                    ans4.Content = "Palmyra";

                    ans1.Tag = "1";

                  

                    break;
                case 9:

                    txtQuestion.Text = "What year did the Roman invasion of Britain take place?";

                    ans1.Content = "43AD";
                    ans2.Content = "50BC";
                    ans3.Content = "140BC";
                    ans4.Content = "20AD";

                    ans1.Tag = "1";

                   

                    break;

                case 10:

                    txtQuestion.Text = "Who said the famous saying...alea iacta est??";

                    ans1.Content = "Marcus Brutus";
                    ans2.Content = "Julius Caeasar";
                    ans3.Content = "Lucius Sulla";
                    ans4.Content = "Pliny The Elder";

                    ans2.Tag = "1";

                   

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


    

