using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace _02_Миллионер
{
    public class XMLSerializer : ISerializer //он универсальный для всех коллекций
    {
        public void Save(ICollection<OneQuestionAndAnswers> collection)
        {
            OneQuestionAndAnswers[] arr = collection.ToArray();
            FileStream stream = new FileStream("../../Q1.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(OneQuestionAndAnswers[]));
            serializer.Serialize(stream, arr);
            stream.Close();
        }
        public ICollection<OneQuestionAndAnswers> Load() //возвращает значение
        {
            FileStream stream;
                stream = new FileStream("../../Q1.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(OneQuestionAndAnswers[]));
                OneQuestionAndAnswers[] arr = (OneQuestionAndAnswers[])serializer.Deserialize(stream);
                stream.Close();
                return new List<OneQuestionAndAnswers>(arr); //создает список и передает ему вопрос
            
        }
    }
}
