using System;
using System.Linq;
using System.Windows;
using Microsoft.Phone.Controls;

namespace HelloPhone
{
    public partial class Game : PhoneApplicationPage
    {
        // Switch for starting and stopping the game
        bool isInPlay = true;

        // Class instantiator
        public Game()
        {
            InitializeComponent();
        }
        // Method for the top player pull button
        private void BtnTopPlayerClick(object sender, RoutedEventArgs e)
        {
            if (isInPlay)
            {
                slider1.Value++;
                CheckIfWinner();
            }
        }
        // Method for the bottom player pull button
        private void BtnBottomPlayerClick(object sender, RoutedEventArgs e)
        {
            if (isInPlay)
            {
                slider1.Value--;
                CheckIfWinner();
            }
        }
        // Method for the resetting the game
        private void ButtonResetClick(object sender, RoutedEventArgs e)
        {
            isInPlay = true;
            slider1.Value = 10;
            textBlockBottom.Text = "";
            textBlockTop.Text = "";
            ButtonReset.Visibility = System.Windows.Visibility.Collapsed;
        }
        // Method for seeing if someone won
        void CheckIfWinner()
        {
            if (slider1.Value == slider1.Maximum)
            {
                isInPlay = false;
                textBlockTop.Text = "Winner";
                ButtonReset.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                if (slider1.Value == slider1.Minimum)
                {
                    isInPlay = false;
                    textBlockBottom.Text = "Winner";
                    ButtonReset.Visibility = System.Windows.Visibility.Visible;
                }
            }
        }
    }
}