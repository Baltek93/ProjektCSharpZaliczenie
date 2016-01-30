using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektCsharp
{

    public partial class MainForm : Form
    {

        /*
        create local value 
        */
        private
            int tymczasowazmiennainteger = 0;
        ContainerPictures temp;
        ControlGuessingGame sterowanie;
        List<ContainerPictures> containerPictures;
        Byte amountCheckPicture;
        ReadFileTxt odczyt;
        Random r = new Random();
        List<RadioButton> radionButtons;
        List<int> templistQuizAnserw;
        TextBox[] textboxs;
        public MainForm()
        {
            InitializeComponent();
 
        }

        private void ReferencePictureBoxes()
        {
            Control[] matches; // create controlers 
            var pictureBoxes = new List<PictureBox>();
            for (int j = 1; j <= 16; j++)
            {
                matches = this.Controls.Find("pictureBox" + j.ToString(), true); // assing name to controllers 
                if (matches.Length > 0 && matches[0] is PictureBox) //check matches is picturebox
                {
                    containerPictures[j - 1].Picture = (PictureBox)matches[0];
                    containerPictures[j - 1].Picture.Visible = true;
                    containerPictures[j - 1].Picture.Image = Properties.Resources.gradient;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            temp = new ContainerPictures();
            amountCheckPicture = 0;
            sterowanie = new ControlGuessingGame();
            containerPictures = new List<ContainerPictures>();
            containerPictures = sterowanie.RandomImageValue();
            ReferencePictureBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
    
            panel3.Visible = false;
            panel4.Visible = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
      
            panel3.Visible = true;
            panel4.Visible = false;

            Quiz quiz = new Quiz();
            odczyt = new ReadFileTxt();
            odczyt.Quizs = odczyt.ReadFile();
            Control[] matches;
            templistQuizAnserw = new List<int>();
            radionButtons = new List<RadioButton>();

            for (int j = 1; j <= 4; j++)
            {

                matches = this.Controls.Find("radioButton" + j.ToString(), true);
                if (matches.Length > 0 && matches[0] is RadioButton)
                {
                    radionButtons.Add((RadioButton)matches[0]);
                    label1.Text = odczyt.Quizs[0].Question;
                    templistQuizAnserw.Add(j - 1);
                }
            }



            //
            losoweodpowiedzi(templistQuizAnserw, radionButtons, 0);

        }

        private void losoweodpowiedzi(List<int> random, List<RadioButton> radionButtons, int numer)
        {
            
            Random r = new Random(); //losowosc 
            for (int i = 0; i < 4; i++)
            {
                int temps;
                temps = r.Next(0, random.Count);
                radionButtons[i].Text = odczyt.Quizs[numer].Anwers[random[temps]];
                random.RemoveAt(temps);
            }
            label1.Text = odczyt.Quizs[numer].Question;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
  
            panel3.Visible = false;
            panel4.Visible = true;
            Control[] matches;
            textboxs = new TextBox[6];
            for (int i = 1; i <= 6; i++)
            {
                matches = this.Controls.Find("textBox" + i.ToString(), true);
                if (matches.Length > 0 && matches[0] is TextBox)
                {
                    textboxs[i - 1] = (TextBox)matches[0];
                    textboxs[i - 1].BackColor = Color.White;
                    textboxs[i - 1].Text = null;
                }
            }
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 0);
            ClearPicture();

        }

        private async void ClearPicture()
        {
            await Task.Delay(300);
            foreach (var item in containerPictures)
            {
                if (item.CheckSelectImage.Equals(true))
                {
                    amountCheckPicture++;
                    temp = item;

                }
            }
            foreach (var item in containerPictures)
                if (amountCheckPicture == 2)
                {
                    if (item.CheckSelectImage == true && item.Picture.Name != temp.Picture.Name && item.CheckImage == temp.CheckImage)
                    {
                        temp.Picture.Visible = item.Picture.Visible = false;


                    }
                    item.CheckSelectImage = false;
                    item.Picture.Image = Properties.Resources.gradient;


                }


            amountCheckPicture = 0;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sterowanie.CheckPicture(containerPictures, 2);
            ClearPicture();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 4);
            ClearPicture();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 6);
            ClearPicture();

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 15);
            ClearPicture();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 13);
            ClearPicture();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 11);
            ClearPicture();



        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 9);
            ClearPicture();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 1);
            ClearPicture();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 3);
            ClearPicture();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 5);
            ClearPicture();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            sterowanie.CheckPicture(containerPictures, 7);
            ClearPicture();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            sterowanie.CheckPicture(containerPictures, 8);
            ClearPicture();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            sterowanie.CheckPicture(containerPictures, 10);
            ClearPicture();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            sterowanie.CheckPicture(containerPictures, 12);
            ClearPicture();

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            sterowanie.CheckPicture(containerPictures, 14);
            ClearPicture();

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (radioButton1.Text == odczyt.Quizs[tymczasowazmiennainteger].Anwers[0])
                {
                    LogicCheckQuestion();

                }
                else
                {
                    MessageBox.Show("Zła odpowiedz");
                }

            }
            if (radioButton2.Checked == true)
            {
                if (radioButton2.Text == odczyt.Quizs[tymczasowazmiennainteger].Anwers[0])
                {
                    LogicCheckQuestion();
                }
                else
                {
                    MessageBox.Show("Zła odpowiedz");
                }
            }
            if (radioButton3.Checked == true)
            {
                if (radioButton3.Text == odczyt.Quizs[tymczasowazmiennainteger].Anwers[0])

                {
                    LogicCheckQuestion();

                }
                else
                {
                    MessageBox.Show("Zła odpowiedz");
                }


            }
            if (radioButton4.Checked == true)
            {
                if (radioButton4.Text == odczyt.Quizs[tymczasowazmiennainteger].Anwers[0])
                {
                    LogicCheckQuestion();
                }
                else
                {
                    MessageBox.Show("Zła odpowiedz");
                }
            }
        }

        private void LogicCheckQuestion()
        {
            MessageBox.Show("Dobra odpowiedz");
            odczyt.Quizs.RemoveAt(tymczasowazmiennainteger);
            if (odczyt.Quizs.Count == 0)
            {
                MessageBox.Show("Quiz Został zakończony");
                panel3.Visible = false;
            }
            else
            {
                tymczasowazmiennainteger = r.Next(0, odczyt.Quizs.Count);
                for (int i = 0; i < 4; i++)
                {
                    templistQuizAnserw.Add(i);
                }

                losoweodpowiedzi(templistQuizAnserw, radionButtons, tymczasowazmiennainteger);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int amountCheckAnserw=0;
            
      
            EqualedString.EquledString(textboxs);

            for (int i = 0; i <= 5; i++)
            {
                if (textboxs[i].BackColor == Color.Blue)
                    amountCheckAnserw++;
            }
            if(amountCheckAnserw==6)
            {
                MessageBox.Show("Wszystkie odpowiedzi Są poprawne");
                panel4.Visible = false;
            }
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacje Stworzył Bartosz Kołtuniak w  ramach zaliczenia projektu z programowania w jezyku C#");
        }
    }
}
