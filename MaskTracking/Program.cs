using Business.Concrete;
using Entities.Concrete;
using System;


namespace MaskTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "ENES";
            person1.Lastname = "GÜNÜMDOĞDU";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 12345678910;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}