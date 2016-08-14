using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Woman
    {
        Cat[] Cats;
        Cat cat1;
        Cat cat2;
        public string name;

        public Woman()
        {
            
            var cat1 = new Cat("Жиробас", 15, "рыба");
          
            var cat2 = new Cat("Федька", 5,"курица");

           
            Cats = new Cat[]{ cat1, cat2 };
         
        }

        public void TellMeAboutYourself()
        {

            for (int i = 0; i < Cats.Length; i++)
            {
                Console.WriteLine($"Одного из котиков зовут {Cats[i].name}, он весит целых {Cats[i].weight}, а кушать любит {Cats[i].favFood}");
                Console.ReadLine();
            }
           /* Console.WriteLine($"Привет, меня зовут {name}, хочешь,я расскажу тебе про моих котиков?");
            Console.ReadLine();
            Console.WriteLine($"Первого котика зовут {Cats[0].name}, о такой милаха, весит {Cats[0].weight} килограммов и еле передвигает своими жирными лапками");
            Console.WriteLine($"Почему он такой жирный? Потому что жрет много {Cats[0].favFood}");
            Console.ReadLine();
            Console.WriteLine($"А второго котика зовут {Cats[1].name}, я его не очень люблю, поэтому он весит всего {Cats[1].weight} килогаммов ");
            Console.WriteLine($"Что он любит есть? Да хрен его знает, вроде {Cats[1].favFood}");
            Console.ReadLine();*/
        }
    }
}
