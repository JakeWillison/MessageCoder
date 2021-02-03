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
        public const int alphaMax = 40;
        private char[] alpha = new char[alphaMax];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fillAlpha(alpha);
            string message = MessageBox.Text.Trim();
            int scrambleNum = int.Parse(ScrambleNumBox.Text.Trim());
            Rearrange(scrambleNum, alpha);
            string newMessage = Scramble(message, alpha);
            ResultBox.Text = newMessage;
        }
        public void fillAlpha(char[] alpha)
        {
            alpha[26] = ' ';
            alpha[27] = '.';
            alpha[28] = ',';
            alpha[29] = '?';
            for(int i = 30; i < 40; i++)
            {
                alpha[i] = (char)(i % 10);
            }
            int index = 0;
            for(int i = 0; i < 26; i++)
            {
                int letNum = i + 65;
                alpha[index] = (char)letNum;
            }
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
            while (ch != newCh && index < alphaMax-1)                 //find letter in new alphabet
            {
                index++;
                newCh = alpha[index];
            }
            index = index + (alphaMax / 2);     //perform ceasar sypher
            index %= alphaMax;
            newCh = alpha[index];
            return newCh;
        }
    }
}
