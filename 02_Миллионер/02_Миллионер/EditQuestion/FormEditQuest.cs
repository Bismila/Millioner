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
    public partial class FormEditQuest : Form, IEditQuestionView
    {
        public FormEditQuest()
        {
            InitializeComponent();
        }


        #region IEditQuestionView Implementation (реализация интерфейса IEditQuestionView)
        public string Quest
        {
            set { textBoxNewQuest.Text = value; }
            get { return textBoxNewQuest.Text; }
        }
        public string Answ1
        {
            set { textBoxFirstAnsw.Text = value; }
            get { return textBoxFirstAnsw.Text; }
        }
        public string Answ2
        {
            set { textBoxSecondAnsw.Text = value; }
            get { return textBoxSecondAnsw.Text; }
        }
        public string Answ3
        {
            set { textBoxThirdAnsw.Text = value; }
            get { return textBoxThirdAnsw.Text; }
        }
        public string Answ4
        {
            set { textBoxFourthAnsw.Text = value; }
            get { return textBoxFourthAnsw.Text; }
        }

        public int numberOfQuest
        {
            get
            {

                //return Int32.Parse(numericUpDown2.Value.ToString());
                return Convert.ToInt32(numericUpDown2.Value);
            }
            set
            {
                numericUpDown2.Value = value;
            }
        }
        public int MaxCountInFormEdit
        {
            get
            {
                return Convert.ToInt32(numericUpDown2.Maximum);
            }
            set
            { numericUpDown2.Maximum = value; }

        }
        // Представление выставляет наружу подписку на происходящие в нем события
        public event EventHandler<EventArgs> buttEditClic; //событие нажатия кнопки "Добавить"
        public event EventHandler<EventArgs> numericChangeNuberOfQuest; //событие перелистывания вопросов
        public void EditQuest()
        {
            MessageBox.Show("Вопрос изменен!", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void noData()
        {
            MessageBox.Show("Пожалуйста, заполните все поля!\n Или нажмите - ОТМЕНА!\n",
                   "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void buttCanselEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            if (buttEditClic != null)
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                buttEditClic(this, EventArgs.Empty);

            Close();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericChangeNuberOfQuest != null)//вызываем событие, которое оповещает о изменении индекса в форме
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                numericChangeNuberOfQuest(this, EventArgs.Empty);
        }
    }
}
