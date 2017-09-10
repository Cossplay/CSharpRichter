using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharoRichter.Chapter5RefValueTypes
{
    class Checked
    {
        // byte вмещает 255
        static void Main(string[] args)
        { 
            byte b = 200;
            /* будет переполнение, тк вмещает byte только 255, но ошибки не будет 
             * переменная когда дойдет до 255 - обнулится и пойдет дальше прибавлять
             * в данном случае 200 + 57 = (256 = 0), (257 = 1)
            */
            b += 57;
            //Чтобы избежать непредвиденных результатов, есть конструкция checked на проверку переполнения типа
            checked
            {
                b += 255; //тут будет overflowexception (b переполнена)
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
