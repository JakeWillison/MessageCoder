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
        public char[] alpha = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '.', '?', ',', ' ', '?', '1', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public bool hasRearranged = false;
        public int scramNum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = MessageBox.Text.Trim();
            int scrambleNum = int.Parse(ScrambleNumBox.Text.Trim());
            char[] newAlpha = alpha;
            Rearrange(scrambleNum, newAlpha);
            string newMessage = Scramble(message, newAlpha);
            ResultBox.Text = newMessage;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            hasRearranged = false;
            ResultBox.Text = "Waiting new message";
            MessageBox.Text = "Enter new message";
            ScrambleNumBox.Text = "##";
        }
        public void Rearrange(int n, char[] newAlpha)  //This function rearranges the alphabet based on the number entered.
        {
            if (!hasRearranged)
            {
                int timesRun = 0;
                do
                {
                    for (int i = 0; i < 13; i++)
                    {
                        char temp = newAlpha[i];
                        newAlpha[i] = newAlpha[i + i];
                        newAlpha[i + i] = temp;
                    }
                    timesRun++;
                } while (timesRun < n);
            }
            hasRearranged = true;
        }

        string Scramble(string message, char[] newAlpha)
        {
            StringBuilder scramMessage = new StringBuilder(message);
            int length = message.Length;
            for(int i = 0; i < length; i++)
            {
                char original = message[i];
                char newCh = flip(original, newAlpha);
                scramMessage[i] = newCh;                //replace letter
                       
            }
            
            return scramMessage.ToString();
        }

        public char flip(char ch, char[] newAlpha)
        {
            int index = 0;
            char newCh = newAlpha[index];
            while (ch != newCh && index < newAlpha.Length-1)                 //find letter in new alphabet
            {
                index++;
                newCh = newAlpha[index];
            }
            index = index + (newAlpha.Length / 2);     //perform ceasar sypher
            if(index % newAlpha.Length > 0)
            {
                index %= newAlpha.Length;
            }
            
            newCh = newAlpha[index];
            return newCh;
        }
    }
}
