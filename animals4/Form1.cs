using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animals4
{
    
    public partial class Form1 : Form
    {
        string correctReply;

        int idx = 0; // это счетчик для переключения надписей и картинок
        string[] game = { "рувас", "карк", "тархъус" }; // это данные для обучения 
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            buttonTrain.Text = "Далее";
           
            
           // buttonTrain.Location = new Point(295, 300);
            buttonTrain.Left = 400;
            buttonTrain.Top = 400;
           // buttonTrain.Right = 150;
            
            buttonTest.Visible = false;
            labelMode.Text = "Обучение";
            AnimalsPicture.Visible = true;
             labelWord.Visible = true;
            string[] dirs = Directory.GetDirectories(@"C:\animals_images\");// список каталога с животными и путь к нему
            string imagePath = dirs[idx] + @"\image.JPEG"; //путь к картинке "C:\animals_image\fox\image.png"
            string wordFileName = dirs[idx] + @"\os.txt";// подобрали путь к текстовому файлу
            string word = File.ReadAllText(wordFileName);//прочитали текст в os.txt             
            AnimalsPicture.ImageLocation = imagePath; //сменили картинку
            labelWord.Text = word; // это меняем текст рядом с изображением
            idx++;              
            if (idx + 1 == dirs.Length)
            {
                idx = 0;
                MessageBox.Show("Вы прошли обучение");
            }
            
                
        }

        private void AnimalsPicture_Click(object sender, EventArgs e)
        {

        }

        private void labelWord_Click(object sender, EventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            buttonTest.Visible = false;
            labelMode.Text = "Режим Тест";
            buttonTrain.Visible = false;
            AnimalsPicture.Visible = true;
            labelWord.Visible = true;
            buttonQuestion1.Visible = true;
            buttonQuestion2.Visible = true;
            string[] dirs = Directory.GetDirectories(@"C:\animals_images\");// список каталога с животными и путь к нему
            string imagePath = dirs[idx] + @"\image.JPEG"; //путь к картинке "C:\animals_image\fox\image.png"
            string wordFileName = dirs[idx] + @"\os.txt";// подобрали путь к текстовому файлу
            string word = File.ReadAllText(wordFileName);//прочитали текст в os.txt 
            labelWord.Text = word;
            var rand = new Random();

            int randomCorrect = rand.Next(0, dirs.Length);
            int randomInvalid = rand.Next(0, dirs.Length);
            while (true)
            {
                if (randomCorrect == randomInvalid)
                {
                    randomCorrect = rand.Next(0, dirs.Length);                    
                }
                else
                {
                    break;
                }
            }
            //string imagePath = dirs[randomCorrect] + @"\image.JPEG";
            AnimalsPicture.ImageLocation = imagePath;

            var buttons = new Button[] { buttonQuestion1, buttonQuestion2 };
            int correctButtonIndex = rand.Next(0, 2);
            int invalidButtonIndex;
            if(correctButtonIndex == 0)
            {
                invalidButtonIndex = 1;
               
            }
            else
            {
                invalidButtonIndex = 0;
            }

            string correct = dirs[randomCorrect] + @"\os.txt";
            string correctWord = File.ReadAllText(correct);
            buttons[correctButtonIndex].Text = correctWord;
            correctReply = correctWord;

            string invalid = dirs[randomInvalid] + @"\os.txt";
            string invalidWord = File.ReadAllText(invalid);
            buttons[invalidButtonIndex].Text = invalidWord;

        }

        private void buttonQuestion2_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            //MessageBox.Show("btn.Text = " + btn.Text + "correctReply = " + correctReply);
            if (btn.Text == correctReply)
            {
                var rand = new Random();
                string[] dirs = Directory.GetDirectories(@"C:\animals_images\");
                int dirIndex = rand.Next(0, dirs.Length);                
                //MessageBox.Show("" + dirIndex);
                string imageFullName = dirs[dirIndex] + @"\image.JPEG";
                AnimalsPicture.ImageLocation = imageFullName;

                string correct = dirs[dirIndex] + @"\os.txt";
                string correctWord = File.ReadAllText(correct);
                buttonQuestion1.Text = correctWord;
                correctReply = correctWord;

                int invalidDirIndex = rand.Next(0, dirs.Length);
                while (true)
                {
                    if (dirIndex == invalidDirIndex)
                    {
                        invalidDirIndex = rand.Next(0, dirs.Length);
                    }
                    else
                    {
                        break;
                    }
                }
                string invalid = dirs[invalidDirIndex] + @"\os.txt";
                string invalidWord = File.ReadAllText(invalid);
                var buttons = new Button[] { buttonQuestion1, buttonQuestion2 };
                int correctButtonIndex = rand.Next(0, 2);
                int invalidButtonIndex;
                if (correctButtonIndex == 0)
                {
                    invalidButtonIndex = 1;

                }
                else
                {
                    invalidButtonIndex = 0;

                }
                buttons[invalidButtonIndex].Text = invalidWord;
                buttons[correctButtonIndex].Text = correctWord;

            }
            else
            {
                MessageBox.Show("неверно");
            }

           
        }

        private void buttonQuestion1_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
           // MessageBox.Show("btn.Text = " + btn.Text + "correctReply = " + correctReply);

            if (btn.Text == correctReply)
            {
            
                var rand = new Random();
                string[] dirs = Directory.GetDirectories(@"C:\animals_images\");
                int dirIndex = rand.Next(0, dirs.Length);
                //MessageBox.Show("" + dirIndex);
                string imageFullName = dirs[dirIndex] + @"\image.JPEG";
                AnimalsPicture.ImageLocation = imageFullName;

                string correct = dirs[dirIndex] + @"\os.txt";
                string correctWord = File.ReadAllText(correct);

                correctReply = correctWord;

                int invalidDirIndex = rand.Next(0, dirs.Length);
                while (true)
                {
                    if (dirIndex == invalidDirIndex)
                    {
                        invalidDirIndex = rand.Next(0, dirs.Length);
                    }
                    else
                    {
                        break;
                    }
                }
                string invalid = dirs[invalidDirIndex] + @"\os.txt";
                string invalidWord = File.ReadAllText(invalid);
                var buttons = new Button[] { buttonQuestion1, buttonQuestion2 };
                int correctButtonIndex = rand.Next(0, 2);
                int invalidButtonIndex;
                if (correctButtonIndex == 0)
                {
                    invalidButtonIndex = 1;

                }
                else
                {
                    invalidButtonIndex = 0;

                }
                buttons[invalidButtonIndex].Text = invalidWord;
                buttons[correctButtonIndex].Text = correctWord;
            }
            else
            {
                MessageBox.Show("No Correct");
            }
            
        }
    }
}
