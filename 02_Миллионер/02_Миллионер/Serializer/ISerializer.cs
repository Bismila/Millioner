using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Миллионер
{
    public interface ISerializer
    {
        void Save(ICollection<OneQuestionAndAnswers> collection);//метод который надо реализовать, ICollection - List наш
        ICollection<OneQuestionAndAnswers> Load(); //метод который надо реализовать
    }
}
