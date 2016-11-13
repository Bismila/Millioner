using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Миллионер
{
    //презентер - посредник, передает данные от view к модели
    class EditPresenter
    {
        private readonly OneQuestionAndAnswers oneQA = new OneQuestionAndAnswers();//ссылка на модель - содержит 1 вопрос и 4 ответа
        private ListQuestions lQA = new ListQuestions();
        private readonly IEditQuestionView _textEditQuestion; //интерфейсная ссылка на удаление вопроса

         // Принцип инверсии зависимостей
        public EditPresenter(IEditQuestionView textQuestion)
        {
            _textEditQuestion = textQuestion;
            lQA.LoadQuestion();
            _textEditQuestion.MaxCountInFormEdit = lQA.ListQA.Count;
            // _textEditQuestion.numberOfQuest = lQA.CurIndexOfQuest;
            // Презентер подписывается на уведомления о событиях Представления
            _textEditQuestion.buttEditClic += new EventHandler<EventArgs>(EventEditQuest);
            _textEditQuestion.numericChangeNuberOfQuest += new EventHandler<EventArgs>(EventChangeTextQuest);
            UpdateView();
        }

    void EventChangeTextQuest(object sender, EventArgs e)//изменение текста вопроса и индекса вопроса в форме
    {
        lQA.CurIndexOfQuest = (_textEditQuestion.numberOfQuest - 1);
       if ((_textEditQuestion.numberOfQuest > 0) && (_textEditQuestion.numberOfQuest < _textEditQuestion.MaxCountInFormEdit))
        // В ответ на изменения в Представлении необходимо изменить Модель
        {
            _textEditQuestion.Quest = lQA.ListQA[_textEditQuestion.numberOfQuest-1].Question; //вопрос вытянули из общего списка вопросов и записали в форму
            _textEditQuestion.Answ1 = lQA.ListQA[_textEditQuestion.numberOfQuest-1].Answer1;
            _textEditQuestion.Answ2 = lQA.ListQA[_textEditQuestion.numberOfQuest-1].Answer2;
            _textEditQuestion.Answ3 = lQA.ListQA[_textEditQuestion.numberOfQuest-1].Answer3;
            _textEditQuestion.Answ4 = lQA.ListQA[_textEditQuestion.numberOfQuest-1].Answer4;

        }
        else if ((_textEditQuestion.numberOfQuest < 0) || (_textEditQuestion.numberOfQuest > _textEditQuestion.MaxCountInFormEdit))
            return;
        
        UpdateView();

    }
        private void EventEditQuest(object sender, EventArgs e)
        {
            lQA.LoadQuestion();
            // В ответ на изменения в Представлении необходимо изменить Модель
            oneQA.Question = _textEditQuestion.Quest;
            oneQA.Answer1 = _textEditQuestion.Answ1;
            oneQA.Answer2 = _textEditQuestion.Answ2;
            oneQA.Answer3 = _textEditQuestion.Answ3;
            oneQA.Answer4 = _textEditQuestion.Answ4;
        
            lQA.EditQuest(_textEditQuestion.numberOfQuest, oneQA);
        
            lQA.SaveQuestion();

            if (_textEditQuestion != null)
            {
                _textEditQuestion.EditQuest();
            }
            else
                _textEditQuestion.noData();
            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
            UpdateView();
        }
        private void UpdateView()
        {
            _textEditQuestion.Quest = lQA.ListQA[_textEditQuestion.numberOfQuest - 1].Question;
            _textEditQuestion.Answ1 = lQA.ListQA[_textEditQuestion.numberOfQuest - 1].Answer1;
            _textEditQuestion.Answ2 = lQA.ListQA[_textEditQuestion.numberOfQuest - 1].Answer2;
            _textEditQuestion.Answ3 = lQA.ListQA[_textEditQuestion.numberOfQuest - 1].Answer3;
            _textEditQuestion.Answ4 = lQA.ListQA[_textEditQuestion.numberOfQuest - 1].Answer4;
        }
    }
  }

