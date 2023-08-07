using System;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

namespace MyClass
{
    class Car
    {
        string rank = "Diamond";
        string level = "1";

        void MyXP()
        {

            Console.WriteLine("Im a pred rank 1");
            Console.WriteLine("|Best player in the LGS");

        }
        void gameData() 
        {
            string platform = "PC";
            string game = "Apex";
            string controls = "Mouse and keyboard";
            Console.WriteLine("platform, game, controls");

        }
        static void Main(string[] args)
        {

         Car canidate1 = new Car();
         Console.WriteLine(canidate1.rank);
            Console.WriteLine("===========");

            Car canidate2 = new Car();
         canidate2.MyXP();
            Console.WriteLine("===========");

            Car canidate3 = new Car();
         Console.WriteLine(canidate3.rank);
         Console.WriteLine(canidate3.level);
         canidate3.gameData();

        }


    }

    public class MyCar
    {

        public string color = "red";
        public string make = "vw";
       public void myTest()
        {

            Console.WriteLine("This is a method in a class");

        }

       
    }
    

}