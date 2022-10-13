using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingForLesson
{
    class Employee
    {
        public string name /*= "Cavid"*/;

        public string surname /*= "Bashirov"*/;

        public int age /*= 29*/;

        public string adress;

        public bool isMarried;


        public Employee(string name, string surname, int age)
        {
            //Console.WriteLine(name + " " + surname + "-" + age);

            this.age = age;
            this.name = name;
            this.surname = surname;

            Console.WriteLine(name + " " + surname);
        }


        public Employee() : this(33)
        {
            Console.WriteLine("Hello P414");
        }

        public Employee(int number)
        {
            Console.WriteLine(number);
        }


        public Employee(string adress) : this()
        {
            this.adress = adress;
            Console.WriteLine(this.adress);
        }

        public Employee(bool isMarried) :/*this()*/this("Ehmedli")
        {
            this.isMarried = isMarried;

            Console.WriteLine(this.isMarried);
        }


        public string GetfullName()
        {
            return name + " " + surname + "-" + age;
        }

        public string GetFullData()
        {
            return $"{GetfullName()}";
        }
    }
}
