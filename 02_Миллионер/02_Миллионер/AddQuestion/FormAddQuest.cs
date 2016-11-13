using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Миллионер
{
    public partial class FormAddQuest : Form, IAddQuestView
    {
        //public static ListQuestions Quest = new ListQuestions();
        public FormAddQuest()
        {
            InitializeComponent();
        }
   
        #region ILoginView Implementation (реализация интерфейса IAddQuestView)
        public string textQustion
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        public string textAnswer1
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }
        public string textAnswer2
        {
            set { textBox3.Text = value; }
            get { return textBox3.Text; }
        }
        public string textAnswer3
        {
            set { textBox4.Text = value; }
            get { return textBox4.Text; }
        }
        public string textAnswer4
        {
            set { textBox5.Text = value; }
            get { return textBox5.Text; }
        }
        // Представление выставляет наружу подписку на происходящие в нем события
        public event EventHandler<EventArgs> buttonAddClic;

        public void AddQuest()
        {
            MessageBox.Show(" Вопрос добавлен", "Отлично", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void noData()
        {
            MessageBox.Show("Вы не ввели вопрос или ввели не все ответы!\n Попробуйте еще раз или нажмите - ОТМЕНА!\n",
                   "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        private void butAddQuestion_Click(object sender, EventArgs e)
        {
            if (buttonAddClic != null)
 // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                buttonAddClic(this, EventArgs.Empty);

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
