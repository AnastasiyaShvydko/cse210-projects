using System.ComponentModel.Design.Serialization;

public class Animation{
    List<string> _animationList = new List<string>();

    public Animation(List<string> list){
        _animationList = list;
    }

    public Animation(){

    }


    public void AnimationCountFunc(int time){
            int i = 0;

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(time);

            while(DateTime.Now < endTime){
                string s = _animationList[i];
                Console.Write(s);
                int lenght = s.Length;
                Thread.Sleep(500);
                Console.Write("\b \b");

                i++;

                if(i >= _animationList.Count){
                    i = 0;
                }
            }
    }

    public void NumbersCountFunc(int time){
        

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(time);

            while(DateTime.Now < endTime){
                for (int i = time ; i > 0; i-- ){
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");

               
                }
            }
    }
}