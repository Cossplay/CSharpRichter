using CSharpRichter.Chapter4Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharoRichter.Chapter4Types.Heap
{
    class Heap
    {     
        void m3()
        {
            #region Объявление переменной
            /* 1) В стеке выделяется переменная Employee и заполняется null
             * 2) В куче создается объект-тип для всех найденых типов
             * 3) тут выделяется 2 типа Employee и Manager (у каждого есть таблица методов, стат. поля, object type pointer, and index)
             * */
            Employee e;
            #endregion

            #region Создание объекта
            /* 1) Cоздается объект в куче
             * 2) Заполняются указатель на объект тип(в данном случае объект тип Manager), экземплярные поля(нулями и null(для ссылок))
             * 3) Вызов конструктора 
             * 4) Возвращает ссылку на объект в переменную "e" (в стеке)
             * */
            e = new Manager();
            #endregion

            #region Вызов статического метода
            /* 1) Берет напрямую из таблицы методов объект типа соответствующий метод 
             * 2) Возвращает ссылку на объект в переменную "e" (в стеке)
             */
            e = Manager.CreateManager();
            #endregion

            #region Вызов экземплярного метода
            /* 1) #region Создание объекта
             * 2) Находит по указателю на объект-тип соотв. объекти тип и выполняет метод
             */
            Manager manager = new Manager();
            manager.InstanceMethod();
            #endregion
        }

    }
    class Manager : Employee
    {
        public static Employee CreateManager()
        {
            return new Manager();
        }
        public void InstanceMethod()
        {
            Console.WriteLine("InstanceMethod");
        }
    }
}
