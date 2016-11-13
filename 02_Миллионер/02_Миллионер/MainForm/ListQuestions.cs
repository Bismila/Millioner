using System;
using System.Collections.Generic;


namespace _02_Миллионер
{
    [Serializable] //сериализация - сохраняем состояние объекта, десериализация - восстанавливаем
    // для XML-сериализации необходим конструктор по умолчанию и открытый доступ к классу
    public class ListQuestions //МОДЕЛЬ для главной формы
    {
        Random rng;
        List<OneQuestionAndAnswers> listQA;
        List<OneQuestionAndAnswers> tmp = new List<OneQuestionAndAnswers>();
        ISerializer serialize = new XMLSerializer();

       int index, countTimer = 60;
    //   IShuffleQuestAndAnsw shuff = new ShuffleQuestAndAnsw();
       
        public ListQuestions() 
        {
            listQA = new List<OneQuestionAndAnswers>();
            index = 1;
            rng = new Random();
        }
        public void SetSerializer(ISerializer serialize)//сеттер для интерфейсной ссылки
        {
            this.serialize = serialize;
        }
        public string CurQuest // свойство для текущего вопроса
        {
            get
            { 
                return listQA[index].Question.ToString();
            }
            set
            {
                listQA[index].Question = value;
            }
        }
        public string CurAnsw1 // свойство для текущего ответа 1
        {
            get
            {
                return listQA[index].Answer1.ToString();
            }
            set
            {
                listQA[index].Answer1 = value;
            }
        }
        public string CurAnsw2 // свойство для текущего ответа 2
        {
            get
            {
                return listQA[index].Answer2.ToString();
            }
            set
            {
                listQA[index].Answer2 = value;
            }
        }
        public string CurAnsw3 // свойство для текущего ответа 3
        {
            get
            {
                return listQA[index].Answer3.ToString();
            }
            set
            {
                listQA[index].Answer3 = value;
            }
        }
        public string CurAnsw4 // свойство для текущего ответа 4
        {
            get
            {
                return listQA[index].Answer4.ToString();
            }
            set
            {
                listQA[index].Answer4 = value;
            }
        }
        public List<OneQuestionAndAnswers> ListQA //св-во для всего списка
        {
            get
            {
                return listQA;
            }
            set
            {
                listQA = value;
            }
        }
        public int CurIndexOfQuest // свойство для текущего индекса вопроса
        {
            get;
            set;
        }
        public int CountTimer
        {
            get{return countTimer;}
            set{countTimer = value;}
        }
        
        public void AddQuest(OneQuestionAndAnswers q)
        {
           this.listQA.Add(q);
           index++;
        }
        public void DelQuest(int index)
        {
            if (index < 0 || index >= listQA.Count)
                return;
            listQA.Remove(listQA[index]);
            index--;
        }
        public void EditQuest(int index, OneQuestionAndAnswers q)
        {
            if (index < 0 || index >= listQA.Count)
                return;
            listQA.Remove(listQA[index]);
            listQA.Insert(Convert.ToInt32(CurIndexOfQuest), q);
        }
        public void SaveQuestion()//сохранение в файл
        {
            serialize.Save(listQA);
        }
        public void LoadQuestion()//загрузка из файла
        {
            listQA = serialize.Load() as List<OneQuestionAndAnswers>;
            foreach (var item in listQA)
            {
                item.CorrectAnswer = item.Answer1;
            }
        }
        public List<OneQuestionAndAnswers> ShuffleQuest(List<OneQuestionAndAnswers> allList)
        {
            List<OneQuestionAndAnswers> copyList = new List<OneQuestionAndAnswers>();
            copyList = allList;
            int n =allList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);

                OneQuestionAndAnswers value = copyList[k];
                copyList[k] = copyList[n];
                copyList[n] = value;
            }  
            return copyList;
        }
        public OneQuestionAndAnswers ShuffleAnswers(OneQuestionAndAnswers oneQuest)
        {

            List<string> copyQuest = new List<string>();
            //OneQuestionAndAnswers copyQuest = new OneQuestionAndAnswers(oneQuest.Question,oneQuest.Answer1,
            //    oneQuest.Answer2, oneQuest.Answer3, oneQuest.Answer4, oneQuest.CorrectAnswer);
            int n = 4;

            copyQuest.Add(oneQuest.Answer1);
            copyQuest.Add(oneQuest.Answer2);
            copyQuest.Add(oneQuest.Answer3);
            copyQuest.Add(oneQuest.Answer4);

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = copyQuest[k];
                copyQuest[k] = copyQuest[n];
                copyQuest[n] = value;
            }
            
            copyQuest.Add(oneQuest.Question);//в самом конце записываем текущий вопрос


            return new OneQuestionAndAnswers(copyQuest[4], copyQuest[0],
                copyQuest[1], copyQuest[2], copyQuest[3], oneQuest.Answer1);
        }
    }
}
