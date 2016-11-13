using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Миллионер
{
    public interface IAddQuestView//интерфейс для формы 2 - добавить вопрос
    {
        string textQustion { get; set; }
        string textAnswer1 { get; set; }
        string textAnswer2 { get; set; }
        string textAnswer3 { get; set; }
        string textAnswer4 { get; set; }

        event EventHandler<EventArgs> buttonAddClic; //событие нажатия кнопки "Добавить"

     void AddQuest();
     //void DelQuest();
     void noData();

       // string UserName { get; set; }
    }
}
