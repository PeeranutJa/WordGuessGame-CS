using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Program01
{
    public partial class Form1 : Form
    {
        //declare variable
        Random random = new Random();
        int index = 0, score = 0,count=1;
        string word;
        public Form1()
        {
            InitializeComponent();
            result.Text = " ";
            result.ForeColor = Color.SteelBlue;
            Score_text.Text = " ";
            Score_text.ForeColor = Color.SteelBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Chooseword()
        {
            //open file and declare variable
            string filePath = @"C:\Users\Luzess\source\repos\CS_Program01\word_list.txt";
            string[] words = File.ReadAllLines(filePath);
            return words[index];
        }

        public void DisplayWord()
        {
            string word_blur = Chooseword();
            int[] used_index = { -1, -1, -1};  

            //random index for not duplicate
            for(int i = 0; i < 3; i++)
            {
                int temp = random.Next(word_blur.Length);
                if (used_index[i] == temp)
                {
                    temp -= 1;
                    used_index[i] = temp;
                }
                else { used_index[i] = temp; }
                
            }

            int pos3 = used_index[1]; 
            int pos2 = used_index[0];
            int pos1 = used_index[2];

            

            word_blur = word_blur.Remove(pos1, 1).Insert(pos1, "_");
            word_blur = word_blur.Remove(pos2, 1).Insert(pos2, "_");
            word_blur = word_blur.Remove(pos3, 1).Insert(pos3, "_");

            Show_word.Text = word_blur;

        }

        public void Checkword()
        {

            //check input compare to answer
            if (Input_word.Text.Equals(word))
            {
                result.Text = "Correct!";
                result.ForeColor = Color.Lime;
                score += 1;
                Score_text.Text = score + "/10";
            }
            else
            {
                result.Text = "Incorrect";
                result.ForeColor = Color.Red;
                Score_text.Text = score + "/10";
            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            index = 0;
            count = 0;
            score = 0;
            Button_Start.Text = "Start";
            Score_text.Text = "0/10";
            result.Text = " ";
            Score_text.ForeColor = Color.White;
            DisplayWord();
            Button_Next.Enabled = true;
            Button_Start.Enabled = false;
            
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if (count == 10)
            {
                Button_Next.Enabled = false;
                Button_Start.Text = "Retry?";
                Button_Start.Enabled = true;
                result.Text = "End game";
                result.ForeColor = Color.White;
            }
            else
            {
                word = Chooseword();
                Checkword();
                index++;
                DisplayWord();
                count++;
            }
            
        }

        private void Input_text(object sender, EventArgs e)
        {
            Input_word.Text = Input_word.Text;
        }

        private void Button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
