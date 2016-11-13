using System;
using System.Xml.Serialization;

namespace _02_Миллионер
{
    [Serializable]
    [XmlRootAttribute("ArrayOfOneQuestionAndAnswers")]
    public class OneQuestionAndAnswers
    {
        string question;
        string answer01;
        string answer02;
        string answer03;
        string answer04;
        string correctAnswer;
   [XmlAttribute]
        public string Question //св-ва для одного вопроса и ответов
       {
           get { return question; }
           set { question = value; } 
       }
   [XmlAttribute]
       public string Answer1
       {
           get { return answer01; }
           set { answer01 = value; }
       }
   [XmlAttribute]
       public string Answer2
       {
           get { return answer02; }
           set { answer02 = value; }
       }
   [XmlAttribute]
       public string Answer3
       {
           get { return answer03; }
           set { answer03 = value; }
       }
   [XmlAttribute]
       public string Answer4
       {
           get { return answer04; }
           set { answer04 = value; }
       }
   public string CorrectAnswer
   {
       get { return correctAnswer; }
       set { correctAnswer = value; }
   }
         public OneQuestionAndAnswers() 
         {
            
         }
        public OneQuestionAndAnswers(string q, string a1, string a2, string a3, string a4, string corransw)
         {
             question = q;
             answer01 = a1;
             answer02 = a2;
             answer03 = a3;
             answer04 = a4;
             correctAnswer = corransw;
         }
    }
}
