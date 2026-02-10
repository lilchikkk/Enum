namespace Enum__numerate_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");
            //kasutate enumit Weekdays ja tahaks näha Friday
            Console.WriteLine(Weekdays.Friday);
            //näha Friday numbrilist väärtust
            Console.WriteLine((int)Weekdays.Friday);
            Console.WriteLine("-----------------------");
            //tehke uus enum Colors
            //väärtused on
            //Red = 3,
            //green = 10,
            //Blue = 13,
            //Yellow = 5,
            //Black = 1,
            //White = 8  
            Console.WriteLine(Colors.Yellow);
            Console.WriteLine((int)Colors.Yellow);//*(int) - castimine*\\,
                                                  //ehk teiseks andmetüübiks
                                                  //juhul kui info võib kaduma minna 
                                                  //ja ei näita soovitud tulemus
        }
        

        enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        enum Colors
        {
            Red=3,
            Green=10,
            Blue=13,
            Yellow=5,
            Black=1,
            White=8
        }


    }
}
