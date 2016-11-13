using System;
using System.Windows.Forms;

namespace _02_Миллионер
{
    public partial class FormDelQuestionByNumber : Form, IDelQuestView
    {
        public FormDelQuestionByNumber()
        {
            InitializeComponent();
        }
        #region Delete Question (реализация интерфейса удаления вопроса)
        public int indexOfQuest
        {
            get
            {
                //return Int32.Parse(UpDown1delQuest.Value.ToString());
                    return Convert.ToInt32(UpDown1delQuest.Value);
            }
            set
            {
                UpDown1delQuest.Value = value;
            }
        }
        public int MaxCountInFormDel
        {
            get
            {
                return Convert.ToInt32(UpDown1delQuest.Maximum); 
            }
            set
            { UpDown1delQuest.Maximum = value; }

        }
        public string quest
        {
            get
            {
                return textBoxDelQuest.Text;
            }
            set
            {
                textBoxDelQuest.Text = value;
            }
        }
        public event EventHandler<EventArgs> buttonDelClic; //событие нажатия кнопки "Удалить"
        public event EventHandler<EventArgs> textIndexsChange; //меняем индекс вопроса

        public void DelQuest()
        {
            MessageBox.Show("Вопрос удален!", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ChangeText()
        {
            //UpDown1delQuest.Value = 0;
        }

        public void noData()
        {
            MessageBox.Show("Это максимальное количество вопросов!", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        private void butDelete_Click(object sender, EventArgs e)
        {
            if (buttonDelClic != null) //вызываем событие, которое удаляет вопрос
            // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
            {
                buttonDelClic(this, EventArgs.Empty);
                Close();
            }
        }

        private void UpDown1delQuest_ValueChanged(object sender, EventArgs e)
        {
            if (textIndexsChange != null)//вызываем событие, которое оповещает о изменении индекса в форме
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                textIndexsChange(this, EventArgs.Empty);
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



       
    }
}
