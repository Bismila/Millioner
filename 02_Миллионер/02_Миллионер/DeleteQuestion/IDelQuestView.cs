using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Миллионер
{
    public interface IDelQuestView
    {
        int indexOfQuest { set; get; }
        int MaxCountInFormDel { set; get; }
        string quest { set; get; }
        event EventHandler<EventArgs> buttonDelClic; //событие нажатия кнопки "Удалить"
        event EventHandler<EventArgs> textIndexsChange;//меняем индекс вопроса
        void DelQuest();
        void ChangeText();
        void noData();
    }
}
