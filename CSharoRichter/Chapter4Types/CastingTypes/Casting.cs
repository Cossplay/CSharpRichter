using CSharpRichter.Chapter4Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharoRichter.Chapter4Types.CastingTypes
{
    class Casting
    {
        static void Main(string[] args)
        {
            #region Явное, неявное приведение типов 
            /* Приведение типа к базовому классу считается безопасным НЕЯВНЫМ(ТЕ без указания к каком типа приводить)
             upcasting safe*/
            Object obj = new Employee();

            /* Тут нужно явное приведение типа
               downcasting unsafe */
            Employee e = (Employee)obj;
            #endregion

            #region Операторы is, as
            //is проверяет совместимость объекта с определенным типом, возвращает boolean
            bool isObject = obj is Object;
            bool isEmployee = obj is Employee;
            // для null ссылок всегда false

            // Из вышесказанного можно проверять тип объекта таким образом
            if(obj is Employee)
            {
                // тут мы точно знаем что объект obj является типом Employee и мы може привести тип obj к Employee (downcasting)
                Employee empl = (Employee)obj;
            }
            /*это проверка достаточно затратна и предолжили механизм приведение с помощью оператора AS
              если преобразование удастся сделать то переменная empl2 != null, в противном случае null */
            Employee empl2 = obj as Employee;
            /* соответсвенно оператор as отличатеся от явного приведения тем, что никогда не вызывается исключение
             Те если не удалось привести тип к другому типу, то ссылка будет попросту равнятся null,
             а приведение employee(obj) выдаст invalidCastException */
            #endregion
        }
    }
}
