using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharoRichter.Chapter5RefValueTypes.BoxUnboxValueTypes.BoxUnbox;

namespace CSharoRichter.Chapter5RefValueTypes.BoxUnboxValueTypes
{
    class MainExample
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10);
            Point p2 = new Point(20, 20);

            // p1 не пакуется тк этот метод перекрыт(вызывает невиртуально)
            Console.WriteLine(p1.ToString());

            // p1 пакуется тк getType метод базового класса (нужна ссылка this)
            Console.WriteLine(p1.GetType()); // "Point"

            // p1 не пакуется тк в структуре есть метод compareTo требующий аргумент Point(те не метод реализованный от интерфейса)
            // p2 не пакуется тк требуется аргумент как раз типа Point
            Console.WriteLine(p1.CompareTo(p2));

            // p1 пакуется, тк Интерфейсы - это ссылочный тип
            IComparable c = p1;
            Console.WriteLine(c.GetType()); // "Point"

            //p1 не пакуется тк вызвана версия реализованная от интерфейса
            //c не пкауется тк это и есть ссылочный тип
            Console.WriteLine(p1.CompareTo(c));

            // c - ссылочный тип
            // p2 пакуется тк c интерфейс и вызывает версию реализованную от интерфейса (compareTo(object o))
            Console.WriteLine(c.CompareTo(p2));

            // Распаковка C из кучи и копирование полей в p2
            p2 = (Point)c;
        }
    }
}
