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

namespace MessageCoder
{
    public partial class MainWindow : Window
    {
        private char[] alpha = new char[26];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = MessageBox.Text.Trim();
            int scrambleNum = int.Parse(ScrambleNumBox.Text.Trim());
            Rearrange(scrambleNum, alpha);
            string newMessage = Scramble(message, alpha);
        }
        public void Rearrange(int n, char[] alpha)  //This function rearranges the alphabet based on the number entered.
        {
            int timesRun = 0;
            do
            {
                for (int i = 0; i < 13; i++)
                {
                    char temp = alpha[i];
                    alpha[i] = alpha[i + i];
                    alpha[i + i] = temp;
                }
                timesRun++;
            } while (timesRun < n);
        }

        string Scramble(string message, char[] alpha)
        {
            //find letter in new alphabet
            //perform ceasar sypher
            //replace letter
            return "temp return";
        }
    }
}
