using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Миллионер
{
    public interface IEditQuestionView
    {
        string Quest { get; set; }
        string Answ1 { get; set; }
        string Answ2 { get; set; }
        string Answ3 { get; set; }
        string Answ4 { get; set; }
        
        int numberOfQuest { set; get; }
        int MaxCountInFormEdit { set; get; }
       
        event EventHandler<EventArgs> buttEditClic; //событие нажатия кнопки "Добавить"
        event EventHandler<EventArgs> numericChangeNuberOfQuest; //событие перелистывания вопросов
        void EditQuest();
        void noData();
    }
}
