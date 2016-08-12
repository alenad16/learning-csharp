using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Woman
    {
        Cat cat1;
        Cat cat2;
        public string name;

        public Woman()
        {
            cat1 = new Cat();
            cat1.name = "Жиробас";
            cat1.weight = 15;
            cat1.favFood = "рыба";

            cat2 = new Cat();
            cat2.name = "Федька";
            cat2.weight = 5;
            cat2.favFood = "курица";
        }

        public void TellMeAboutYourself()
        {
            Console.WriteLine($"Привет, меня зовут {name}, хочешь,я расскажу тебе про моих котиков?");
            Console.ReadLine();
            Console.WriteLine($"Первого котика зовут {cat1.name}, о такой милаха, весит {cat1.weight} килограммов и еле передвигает своими жирными лапками");
            Console.WriteLine($"Почему он такой жирный? Потому что жрет много {cat1.favFood}");
            Console.ReadLine();
            Console.WriteLine($"А второго котика зовут {cat2.name}, я его не очень люблю, поэтому он весит всего {cat2.weight} килогаммов ");
            Console.WriteLine($"Что он любит есть? Да хрен его знает, вроде {cat2.favFood}");
            Console.ReadLine();
        }
    }
}
