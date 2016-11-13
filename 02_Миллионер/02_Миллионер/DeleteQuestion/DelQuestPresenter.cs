using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Миллионер
{
    //презентер - посредник, передает данные от view к модели
    class DelQuestPresenter
    {
        private readonly OneQuestionAndAnswers oneQA = new OneQuestionAndAnswers();//ссылка на модель - содержит 1 вопрос и 4 ответа
        private ListQuestions lQA = new ListQuestions();
        private readonly IDelQuestView _textDelQuestions; //интерфейсная ссылка на удаление вопроса

         // Принцип инверсии зависимостей
        public DelQuestPresenter(IDelQuestView textQuestions)
        {
           // if(_textDelQuestions.indexOfQuest)
            lQA.LoadQuestion();
            _textDelQuestions = textQuestions;
            _textDelQuestions.MaxCountInFormDel = lQA.ListQA.Count;
          
            // Презентер подписывается на уведомления о событиях Представления
            _textDelQuestions.textIndexsChange += new EventHandler<EventArgs>(EventChangeTextQuest);
            _textDelQuestions.buttonDelClic += new EventHandler<EventArgs>(EventDelQuest);
            UpdateView();
        }

    void EventChangeTextQuest(object sender, EventArgs e)//изменение текста вопроса и индекса вопроса в форме
    {
        lQA.CurIndexOfQuest = (_textDelQuestions.indexOfQuest - 1);
       if (_textDelQuestions.indexOfQuest > 0 && _textDelQuestions.indexOfQuest <= _textDelQuestions.MaxCountInFormDel)
        // В ответ на изменения в Представлении необходимо изменить Модель
        {
            _textDelQuestions.quest = lQA.ListQA[(_textDelQuestions.indexOfQuest)-1].Question; //вопрос вытянули из общего списка вопросов и записали в форму
        }
       else if ((_textDelQuestions.indexOfQuest < 0) || (_textDelQuestions.indexOfQuest > _textDelQuestions.MaxCountInFormDel))
           return;
      
        UpdateView();

    }
        private void EventDelQuest(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            lQA.DelQuest(_textDelQuestions.indexOfQuest-1);
            lQA.SaveQuestion();
            if (_textDelQuestions != null)
            {
                _textDelQuestions.DelQuest();
            }
            else
                _textDelQuestions.noData();
            _textDelQuestions.MaxCountInFormDel--;

            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
            UpdateView();
        }
        private void UpdateView()
        {
         _textDelQuestions.quest = lQA.ListQA[_textDelQuestions.indexOfQuest - 1].Question;
        }
    }
}

