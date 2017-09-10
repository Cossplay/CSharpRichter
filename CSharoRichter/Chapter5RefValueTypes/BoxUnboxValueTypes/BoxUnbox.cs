using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharoRichter.Chapter5RefValueTypes.BoxUnboxValueTypes
{
    class BoxUnbox
    {
        static void Main(string[] args)
        {
            #region Упаковка
            // Структура Point хранится в стеке
            Point p = new Point(1,1);
            /* На данном этапе происходит упаковка значимого типа в ссылочный
             * 1) Выделяется память в куче и происходит копирование полей значимого типа в обертку которая находится куче(object type)
             * */
            object o = p;
            #endregion

            #region Распаковка
            //Тут происходит распаковка
            /* 1) У объекта в куче (o) берется указатель на значимый тип (Point)
             * 2) В стеке создается новая переменная и происходит копирование полей из кучи в стек (значимый тип Point)
             * 3) Изменяя данные переменные o и pNew мы получим разные результаты, тк они независимы друг от друга(живут в стеке и куче)
             */
            Point pNew = (Point)o;
            pNew.x = pNew.y = 2;
            Console.WriteLine(pNew.ToString());
            Console.WriteLine(o);
            #endregion

            #region Упаковка + приведение 
            int i = 5;     //Значимый тип в стеке
            object o2 = i;  // упаковка значимого типа

            // попытка распаковки выдаст InvalidCastException
            /*1) при распаковки указатель на значимый тип будет ссылатся на int
             *  но в данном примере попытка распокавать в long 
             *  2) InvalidCastException, так нельзя делать
             */
            long l = (long)o2;

            // правильный вариант предыдущего примера
            long l2 = (long)(int)o2;
            #endregion
        }

        #region Структура Point
        struct Point
        {
            public int x;
            public int y;
            public Point(int _x, int _y)
            {
                this.x = _x;
                this.y = _y;
            }
            public override string ToString()
            {
                return String.Format("{0}, {1}", x, y);
            }
        }
        #endregion
    }
}
