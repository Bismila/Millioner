using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _02_Миллионер
{
  public interface IMainFormView
    {
      string TextCurrentQuestion { get; set; }
      string TextButtonAnsw1 { get; set; }
      string TextButtonAnsw2 { get; set; }
      string TextButtonAnsw3 { get; set; }
      string TextButtonAnsw4 { get; set; }
      string ButtonAnswers { get; set; }
      bool SwichGalkin { get; set; }
      string TextGalkin { get; set; }
      bool SwichCallFriend { get; set; }
      string TextCallFriend { get; set; }
   //   bool EnabledAnswers { get; set; }
      int ProgressBarA { get; set; }
      int ProgressBarB { get; set; }  
      int ProgressBarC { get; set; }   
      int ProgressBarD { get; set; }
      string ValueProgressBar1 { get; set; }
      string ValueProgressBar2 { get; set; }
      string ValueProgressBar3 { get; set; }
      string ValueProgressBar4 { get; set; }
      bool GroupBoxHelpRoom { get; set; }
      string ListBox { get; set; }
      event EventHandler<EventArgs> ClicButtonNewGame;
      //event EventHandler<EventArgs> ClicButtonExit;
      event EventHandler<EventArgs> ClicButton50on50;
      event EventHandler<EventArgs> ClicButtonCallFriend;
      event EventHandler<EventArgs> ClicButtonHelpRoom;
      event EventHandler<EventArgs> ClicButtonAnswers;
      event EventHandler<EventArgs> NextQuest;
     
      void ChangeColorButt(Button obj);//цвет кнопки если нажат верный ответ
      void NotChangeColorButt(Button obj);//цвет кнопки если нажат не верный ответ
      void GameOver(Timer t);
      void Win();
      void SoundRightAnswer();
    }
}
