using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Abstract_Class_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
           IQuittable quittable = new Employee(); // Create an object of the Employee class and have it inherit from the IQuittable interface
            quittable.Quittable(quittable); // Call the method Quittable on the object of Employee




        }

    

    }
}


 
        
    

    

