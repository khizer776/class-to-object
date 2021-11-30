using System;

namespace class_to_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Person khizer = new Person();
            khizer.firstName = "Khizer";
            khizer.lastName = "Rehman";
            khizer.introduce();


            calculator cal = new calculator();
            float x = cal.add(70,10);
            Console.WriteLine(x);

    
        }
    }
}
