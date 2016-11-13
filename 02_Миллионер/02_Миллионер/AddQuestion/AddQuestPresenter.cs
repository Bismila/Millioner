using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _02_Миллионер
{
    //презентер - посредник, передает данные от view к модели
    public class AddQuestPresenter      
    {
        private readonly OneQuestionAndAnswers oneQA = new OneQuestionAndAnswers();
        private readonly IAddQuestView _textQuestions;

         // Принцип инверсии зависимостей
        public AddQuestPresenter(IAddQuestView textQuestions)
        {
            _textQuestions = textQuestions;
            // Презентер подписывается на уведомления о событиях Представления
            _textQuestions.buttonAddClic += new EventHandler<EventArgs>(ChangeQuest);
            UpdateView();
        }
        private void ChangeQuest(object sender, EventArgs e)
        {
            
            ListQuestions lQA = new ListQuestions();
            lQA.LoadQuestion();
            // В ответ на изменения в Представлении необходимо изменить Модель
            oneQA.Question = _textQuestions.textQustion;
            oneQA.Answer1 = _textQuestions.textAnswer1;
            oneQA.Answer2 = _textQuestions.textAnswer2;
            oneQA.Answer3 = _textQuestions.textAnswer3;
            oneQA.Answer4 = _textQuestions.textAnswer4;
           
            lQA.AddQuest(oneQA);
            lQA.SaveQuestion();
            if (_textQuestions != null)
                _textQuestions.AddQuest();
            else
               _textQuestions.noData();
            // В данной форме этот вызов не нужен, однако в общем
            // случае изменение части Модели может привести к изменениям
            // в других ее частях. Поэтому необходимо синхронизировать
            // Представление с новым текущим состоянием Модели.
            UpdateView();
        }
        private void UpdateView()
        {
            _textQuestions.textQustion = oneQA.Question;
            _textQuestions.textAnswer1 = oneQA.Answer1;
            _textQuestions.textAnswer2 = oneQA.Answer2;
            _textQuestions.textAnswer3 = oneQA.Answer3;
            _textQuestions.textAnswer4 = oneQA.Answer4;
        }
    }
}
