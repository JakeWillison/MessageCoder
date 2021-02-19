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
        public char[] alpha = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '.', '?', ',', '1', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

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
            ResultBox.Text = newMessage;
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
            StringBuilder scramMessage = new StringBuilder(message);
            int length = message.Length;
            for(int i = 0; i < length; i++)
            {
                char original = message[i];
                char newCh = flip(original, alpha);
                scramMessage[i] = newCh;                //replace letter
                       
            }
            
            return scramMessage.ToString();
        }

        public char flip(char ch, char[] alpha)
        {
            int index = 0;
            char newCh = alpha[index];
            while (ch != newCh && index < alpha.Length-1)                 //find letter in new alphabet
            {
                index++;
                newCh = alpha[index];
            }
            index = index + (alpha.Length / 2);     //perform ceasar sypher
            index %= alpha.Length;
            newCh = alpha[index];
            return newCh;
        }
    }
}
