using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean value type (değer tip)
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayı 1  :" + sayi1);

            //arrays,class,interface reference type (referans tip)
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("sayılar[0] =" + sayilar1[0]);
            Console.WriteLine(sayilar1[2]);



            Person person = new Person();
            Person person2 = new Person();

            person.FirstName = "Barkın";
            person2 = person;
            person.FirstName = "beril";
            Console.WriteLine(person2.FirstName);


            Custemer custemer = new Custemer();
            Employee employee = new Employee();

        }
    }

    class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Custemer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
