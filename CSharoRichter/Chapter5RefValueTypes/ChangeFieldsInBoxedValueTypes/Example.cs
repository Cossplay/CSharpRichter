using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharoRichter.Chapter5RefValueTypes.ChangeFieldsInBoxedValueTypes
{
    class Example
    {
        public static void Main(string[] args)
        {
            Point p = new Point(1, 1);
            Console.WriteLine(p);

            p.Change(2, 2);
            Console.WriteLine(p);

            Object o = p;
            Console.WriteLine(o);
  
            //PS Никак нельзя изменить поля в упакованном объекте*

            // Происходит распаковка в тип Point и вызов метода change
            // поля o копирутся во временный объект струтуры Point
            // но это не никак не влияеет на o и p
            ((Point)o).Change(3, 3);
            Console.WriteLine(o);

            /* *Есть возможность изменить поля упакованного объекта через интерфейс
             * Опеределим IChangeBoxedPoint с методом change
             * Реализуем в структуре этот метод
             * Ниже p упаковывается, соотв. соаздется объект в куче у которого мы изменяем поля 4 ,4
             * Но он сразу же подхватывается сборщиком мусора, тк на этот объект никто не ссылается
             * ((IChangeBoxedPoint)p).Change(4,4)
             * Соотв. структуру p мы не изменили
             * След. пример
             * ((IChangeBoxedPoint)o).Change(5,5)
             * В этом примере никакая упаковка не происходит
             * Тем самым у упакованного объекта o изменяем поля на 5,5
             * Получается что через интерфейсы можно менять поля упакованных объектов
             */
        }
        #region Структура Point
        internal struct Point
        {
            private int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Change(int x, int y)
            {
                this.x = x; this.y = y;
            }
            public override string ToString()
            {
                return String.Format("{0}, {1}", x , y);
            }
        }
        #endregion
    }
}
