using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
namespace _02_Миллионер
{
    public partial class Form1 : Form, IMainFormView
    {
        //int countTimer = 60;
        int n = 14;
        public Form1()
        {
            InitializeComponent();
         
            SwichGalkin = false;
            TextGalkin = "";
            SwichCallFriend = false;
            TextCallFriend = "";
            GroupBoxHelpRoom = false;
            labelTheEnd.Visible = false;

        }

        #region IMainFormView Implementation (реализация интерфейса IMainFormView)
       public string TextCurrentQuestion 
        { 
            get {return labelQuestion.Text;}
            set { labelQuestion.Text = value; }
        }
       public string TextButtonAnsw1 
        {
            get{return butAnswer1.Text;}
            set 
            {
                butAnswer1.Text =value;
               butAnswer1.BackColor = Color.Black;
            }
        }
       public string TextButtonAnsw2
        {
            get { return butAnswer2.Text; }
            set 
            {
                butAnswer2.Text = value;
                butAnswer2.BackColor = Color.Black;
            }
        }
       public string TextButtonAnsw3
        {
            get { return butAnswer3.Text; }
            set 
            {
                butAnswer3.Text = value;
                butAnswer3.BackColor = Color.Black;
            }
        }
       public string TextButtonAnsw4 
        {
            get { return butAnswer4.Text; }
            set 
            {
                butAnswer4.Text = value;
                butAnswer4.BackColor = Color.Black;
            }
        }
       public string ButtonAnswers 
       {
           get;
           set;
       }
       public void ChangeColorButt(Button obj)
       {
          obj.BackColor = Color.Lime;
       }
       public void NotChangeColorButt(Button obj)
       {
           obj.BackColor = Color.Red;
       }
       public bool SwichGalkin 
       { 
           get{return pictureBox2.Visible;}
           set { pictureBox2.Visible = value; }
       }
       public string TextGalkin 
       {
           get { return label7.Text; }
           set { label7.Text = value; }
       }
       public bool SwichCallFriend 
       {
           get { return pictureBox1.Visible; }
           set { pictureBox1.Visible = value; }
       }
       public string TextCallFriend 
       {
           get { return label1.Text; }
           set { label1.Text = value; }
       }
      
       public int ProgressBarA 
       {
           get { return progressBar1.Value; }
           set { progressBar1.Value = value; }
       }
       public int ProgressBarB
       {
           get { return progressBar2.Value; }
           set { progressBar2.Value = value; }
       }
       public int ProgressBarC
       {
           get { return progressBar3.Value; }
           set { progressBar3.Value = value; }
       }
       public int ProgressBarD
       {
           get { return progressBar4.Value; }
           set { progressBar4.Value = value; }
       }
       public string ValueProgressBar1 
       {
           get { return label15.Text; }
           set { label15.Text = value; }
       }
       public string ValueProgressBar2
       {
           get { return label14.Text; }
           set { label14.Text = value; }
       }
       public string ValueProgressBar3
       {
           get { return label13.Text; }
           set { label13.Text = value; }
       }
       public string ValueProgressBar4
       {
           get { return label12.Text; }
           set { label12.Text = value; }
       }
       public bool GroupBoxHelpRoom 
       {
           get { return groupBox2.Visible; }
           set { groupBox2.Visible = value;}
       }
       public string ListBox 
       {
           get { return labelTheEnd.Text; }
           set { labelTheEnd.Text = value; }
       }
       
        public event EventHandler<EventArgs> ClicButtonNewGame;
        public event EventHandler<EventArgs> ClicButton50on50;
        public event EventHandler<EventArgs> ClicButtonCallFriend;
        public event EventHandler<EventArgs> ClicButtonHelpRoom;
       public event EventHandler<EventArgs> ClicButtonAnswers;
       public event EventHandler<EventArgs> NextQuest;
       public void GameOver(Timer t)//проигрыш
       {
           SoundPlayer player = new SoundPlayer("../../false.wav");
           player.Play();
           butAnswer1.Visible = false;
           butAnswer2.Visible = false;
           butAnswer3.Visible = false;
           butAnswer4.Visible = false;
           labelQuestion.Visible = false;
           labelTheEnd.Visible = true;
           labelTheEnd.Text = "Вы проиграли! Игра окончена!";
         
           listBox1.SetSelected(n, false);

           //администраторскийРежимToolStripMenuItem1.Visible = true;
           администраторскийРежимToolStripMenuItem1.Enabled = true;
       }
       public void Win()//победа
       {
           SoundPlayer player = new SoundPlayer("../../winner.wav");
           player.Play();
           butAnswer1.Visible = false;
           butAnswer2.Visible = false;
           butAnswer3.Visible = false;
           butAnswer4.Visible = false;
           labelQuestion.Visible = false;
           labelTheEnd.Visible = true;
     
           int index = listBox1.SelectedIndex;
           if (index >= 0)
           {
               string str = (string)listBox1.Items[n];
               int del = str.IndexOf('.');
               if (del > 0)
                   str = str.Remove(0, del + 1);
               labelTheEnd.Text = "Поздравляю! Игра окончена! Вaш выигрыш " + str;
           }
           else return;

       }
      public void SoundRightAnswer()
       {
           SoundPlayer player = new SoundPlayer("../../true.wav");
           player.Play();
       }
       
        #endregion
     
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void butNewGame_Click(object sender, EventArgs e)
        {
            butt50on50.BackgroundImage = _02_Миллионер.Properties.Resources._1;
            butt50on50.Enabled = true;
            buttCallFriend.BackgroundImage = _02_Миллионер.Properties.Resources._2;
            buttCallFriend.Enabled = true;
            buttHelpPeopleRoom.BackgroundImage = _02_Миллионер.Properties.Resources._3;
            buttHelpPeopleRoom.Enabled = true;
            butAnswer1.Visible = true;
            butAnswer2.Visible = true;
            butAnswer3.Visible = true;
            butAnswer4.Visible = true;
            labelQuestion.Visible = true;

            labelTheEnd.Visible = false;
            n = 14;
            listBox1.SetSelected(n, true);
          
            if (ClicButtonNewGame != null) //вызываем событие, которое удаляет вопрос
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                {
                    ClicButtonNewGame(this, EventArgs.Empty);
                }
        }
        private void новаяИграToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            администраторскийРежимToolStripMenuItem1.Enabled = false;
            butNewGame.PerformClick();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("../../begin.wav");
            player.Play();
        }

        private void добавитьВопросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddQuest form = new FormAddQuest();
            AddQuestPresenter addPresenter = new AddQuestPresenter(form);

            form.ShowDialog();
           
         }

        private void удалитьВопросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDelQuestionByNumber fr = new FormDelQuestionByNumber();
            DelQuestPresenter delPresenter = new DelQuestPresenter(fr); 

            fr.ShowDialog();
        }

        private void редактироватьВопросToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEditQuest form = new FormEditQuest();
            EditPresenter editPresenter = new EditPresenter(form);

            form.ShowDialog();
        }

       private void butExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butAnswer1_Click_1(object sender, EventArgs e)
        {
            try
            {
            
            if (n < 0)
                return;
                Button obj = (Button)sender;
                ButtonAnswers = obj.Text; //запомнили текст который пришел с кнопки
                if ( ClicButtonAnswers!= null) 
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                {
                    ClicButtonAnswers(sender, EventArgs.Empty);
                }
                if (NextQuest != null) //вызываем событие, которое удаляет вопрос
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                {
                    listBox1.SetSelected(n, true); //для выделения цветом в листбоксе опр-ой суммы
                    n--;
                        NextQuest(sender, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butt50on50_Click(object sender, EventArgs e)
        {
            try
            {
                  SoundPlayer player = new SoundPlayer("../../gong.wav");
                player.Play();
                butt50on50.BackgroundImage=_02_Миллионер.Properties.Resources._4;
                butt50on50.Enabled = false;
                if (ClicButton50on50 != null) //вызываем событие, которое удаляет вопрос
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                {
                    ClicButton50on50(sender, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttCallFriend_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer("../../zvonok.wav");
                player.Play();
               buttCallFriend.BackgroundImage = _02_Миллионер.Properties.Resources._5;
               buttCallFriend.Enabled = false;

                if (ClicButtonCallFriend != null) //вызываем событие, которое удаляет вопрос
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                {
                    ClicButtonCallFriend(sender, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttHelpPeopleRoom_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer("../../zal.wav");
                player.Play();
                buttHelpPeopleRoom.BackgroundImage = _02_Миллионер.Properties.Resources._6;
                buttHelpPeopleRoom.Enabled = false;
                if (ClicButtonHelpRoom != null) //вызываем событие, которое удаляет вопрос
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                {
                    ClicButtonHelpRoom(sender, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit.PerformClick();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Rools.txt");
        }

        private void LabelAnswers(object sender, EventArgs e)
        {

        }
        //D:\!!!ШАГ\Программирование платформа DOTNET\Программирование С#\Windows Forms\WF_ДЗ\02_Миллионер\02_Миллионер
    }
}
