using System;
using System.Collections.Generic;
using System.Text;
/*Задание
1) Создать класс
 - 3 свойства
 - 1 метод
 - конструктор для свойств
2) Создать переменную типа List<%your_class_name%>
3) Для этой переменной:
 - добавить 1 обьект
 - добавить набор обьектов
 - удалить нужный обьект
 - удалить по индексу*/
namespace ObjectVariableList
{
    class ClassMethodConstructorPropertiesList
    {
        public string clas { get; set; }
        public int method { get; set; }
        public decimal properties { get; set; }

        public static string method_NoLoveCorona()
        {
            return "No love carantin ";
        }
        public ClassMethodConstructorPropertiesList(string clas, int method, decimal properties)
        {
            this.clas = clas;
            this.method = method;
            this.properties = properties;
        }

        public static explicit operator string(ClassMethodConstructorPropertiesList v)
        {
            throw new NotImplementedException();
        }
    }
}
