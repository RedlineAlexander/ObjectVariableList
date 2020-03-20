using System;
using System.Collections.Generic;
/*
 * Задание
1) Создать класс
 - 3 свойства
 - 1 метод
 - конструктор для свойств
2) Создать переменную типа List<%your_class_name%>
3) Для этой переменной:
 - добавить 1 обьект
 - добавить набор обьектов
 - удалить нужный обьект
 - удалить по индексу
 */
namespace ObjectVariableList
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassMethodConstructorPropertiesList classMethodConstructorPropertiesList = new ClassMethodConstructorPropertiesList("mama mia", 29, 16);
            List<string> carantino_list = new List<string>();
            
            carantino_list.Add("Full trash");
           // carantino_list.AddRange((string)classMethodConstructorPropertiesList);
            carantino_list.AddRange(new string [] { "dont like", "not alike", "hate carantin" });
            carantino_list.RemoveAt(0);
            carantino_list.Remove("Epic Fail");

            Console.WriteLine("Hello World!");
        }
    }
}
