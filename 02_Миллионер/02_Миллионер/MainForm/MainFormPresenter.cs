using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Миллионер
{
   public class MainFormPresenter
    {
        private readonly ListQuestions AllList = new ListQuestions();
        private readonly IMainFormView _textMainForm;
        List<OneQuestionAndAnswers> q;
        ListQuestions tmp = new ListQuestions();
       public int i = 0;
      // public int countTimer = 0;

        List<string> correctAnsw = new List<string>();

        public MainFormPresenter(IMainFormView textMainForm)
        {
            //Загружаем все вопросы из файла в лист
            ISerializer serializer = new XMLSerializer();
            AllList.SetSerializer(serializer);
            AllList.LoadQuestion();
          
            _textMainForm = textMainForm;
            // Презентер подписывается на уведомления о событиях Представления
            _textMainForm.ClicButtonNewGame += new EventHandler<EventArgs>(LoadOneQuestionInLabel);
            _textMainForm.ClicButtonAnswers += new EventHandler<EventArgs>(CheckAnswerAndNext);
            _textMainForm.NextQuest += new EventHandler<EventArgs>(NextQuestion);
            _textMainForm.ClicButton50on50 += EventClicButton50on50;
            _textMainForm.ClicButtonCallFriend += EventClicButtonCallFriend;
            _textMainForm.ClicButtonHelpRoom += EventClicButtonHelpRoom;
          //  UpdateView();
        }

        void EventClicButtonHelpRoom(object sender, EventArgs e)//помощь зала???????
        {
            _textMainForm.GroupBoxHelpRoom = true;

            if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw1.Substring(3))//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.ProgressBarA = 50;
                _textMainForm.ProgressBarB = 10;
                _textMainForm.ProgressBarC = 20;
                _textMainForm.ProgressBarD = 30;
            }
            if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw2.Substring(3))//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.ProgressBarB = 50;
                _textMainForm.ProgressBarA = 10;
                _textMainForm.ProgressBarC = 20;
                _textMainForm.ProgressBarD = 30;
            } if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw3.Substring(3))//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.ProgressBarC = 50;
                _textMainForm.ProgressBarA = 10;
                _textMainForm.ProgressBarB = 20;
                _textMainForm.ProgressBarD = 30;
            } if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw4.Substring(3))//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.ProgressBarD = 50;
                _textMainForm.ProgressBarA = 10;
                _textMainForm.ProgressBarC = 20;
                _textMainForm.ProgressBarB = 30;
            }
            UpdateHelpRoom();
        }
       private void UpdateHelpRoom()// перерисовываем окно для помощи из зала
        {
            _textMainForm.ValueProgressBar1 = (_textMainForm.ProgressBarA).ToString()+"%";
            _textMainForm.ValueProgressBar2 = (_textMainForm.ProgressBarB).ToString() + "%";
            _textMainForm.ValueProgressBar3 = (_textMainForm.ProgressBarC).ToString() + "%";
            _textMainForm.ValueProgressBar4 = (_textMainForm.ProgressBarD).ToString() + "%"; 
 
        }

        void EventClicButtonCallFriend(object sender, EventArgs e)//звонок другу
        {
            Button obj = sender as Button;
            _textMainForm.SwichCallFriend = true;
            _textMainForm.TextCallFriend = "Я думаю, правильный ответ...\nЭто ";// +q[i].CorrectAnswer;
            
            Timer answ = new Timer();
            answ.Interval = 3000;
            answ.Enabled = true;
            answ.Tick += answTick;
            answ.Start();
        }
        void answTick(object sender, EventArgs e)//событие для ответа - звонок другу - таймер
        {
            Timer tAnsw = (Timer)sender;
            tAnsw.Stop();
            _textMainForm.TextCallFriend +=" " + q[i].CorrectAnswer;
            
        }

        void EventClicButton50on50(object sender, EventArgs e)//50х5
        {
            if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw1.Substring(3))//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.TextButtonAnsw2 = "";
                _textMainForm.TextButtonAnsw3 = "";
            }
            if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw2.Substring(3))//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.TextButtonAnsw1 = "";
                _textMainForm.TextButtonAnsw4 = "";
            } if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw3.Substring(3))//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.TextButtonAnsw1 = "";
                _textMainForm.TextButtonAnsw2 = "";
            } if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw4.Substring(3))//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.TextButtonAnsw3 = "";
                _textMainForm.TextButtonAnsw2 = "";
            }
        }

        void CheckAnswerAndNext(object sender, EventArgs e)//проверяем ответ и выводим следующий вопрос
        {
            Button obj = sender as Button;
           // if(i == q.Count - 2)
            if (i == 14)//если к-во вопросов достигло 15ти - Выигрыш!
            {
                _textMainForm.Win();
                return;
            }
            if (obj.Text.Substring(3) == q[i].CorrectAnswer)//Если ответ на вопрос верный; tmp.ListQA[i].CorrectAnswer
            {
                _textMainForm.SwichGalkin = true;
                _textMainForm.SoundRightAnswer();
                _textMainForm.TextGalkin = "Правильно!!!";
                _textMainForm.ChangeColorButt(obj);//меняем цвет кнопки
                    i++;
            }
            else 
            {
                _textMainForm.NotChangeColorButt(obj);
                _textMainForm.SwichGalkin = true;
                _textMainForm.TextGalkin = "Не правильно!";
                Timer t = new Timer();
                t.Interval = 1000;
                t.Enabled = true;
                t.Tick += new EventHandler(t_Tick);
                t.Start();
            }
        }
       private void NextQuestion(object sender, EventArgs e)//следующий вопрос, если верно ответили на предыдущий
         {
             Timer tPause = new Timer();
             tPause.Interval = 1000;
             tPause.Enabled = true;
             tPause.Tick += tPause_Tick;
             tPause.Start();
         }
         void tPause_Tick(object sender, EventArgs e)//пауза перед выводом след-го вопроса
         {
             Timer tPause = (Timer)sender;
             tPause.Stop();
             UpdateView();
         }
         void t_Tick(object sender, EventArgs e)//выводим сообщение что игра окончена
         {
            
             Timer t = (Timer)sender;
             t.Stop();
             _textMainForm.GameOver(t);
                
         }
        private void LoadOneQuestionInLabel(object sender, EventArgs e)//событие для кн"Новая игра"
        {
            AllList.LoadQuestion();
          q = new List<OneQuestionAndAnswers>();
            //перемешали все вопросы и вернули уже перемешанный список вопросов в новый лист
            tmp.ListQA = tmp.ShuffleQuest(AllList.ListQA);
            //перемешиваем в каждом вопросе (из временного листа) все ответы
           i = 0;
            while (i < tmp.ListQA.Count)
            {
        //закинули тек-й вопрос, перемешали в нем ответы, зафксировали верный ответ и вернули обратно вопрос с ответами
                 q.Add(tmp.ShuffleAnswers(tmp.ListQA[i]));
                  tmp.CurIndexOfQuest++;
                  i++;
            }
            i = 0;
           UpdateView(); //перерис-ем окно с новыми данными

        }

        private void UpdateView()//перерисовываем главное окно
        {
            _textMainForm.SwichGalkin = false;
            _textMainForm.TextGalkin = "";
            _textMainForm.TextCurrentQuestion = q[i].Question;
            _textMainForm.TextButtonAnsw1 = "A: " + q[i].Answer1;
            _textMainForm.TextButtonAnsw2 = "B: " + q[i].Answer2;
            _textMainForm.TextButtonAnsw3 = "C: " + q[i].Answer3;
            _textMainForm.TextButtonAnsw4 = "D: " + q[i].Answer4;

            _textMainForm.SwichCallFriend = false;
            _textMainForm.TextCallFriend = "";

            _textMainForm.GroupBoxHelpRoom = false;
        }
    }
}
