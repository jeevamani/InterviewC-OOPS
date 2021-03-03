using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Contructors
{
   public class CopyConstructor
    {
        /*
         The constructor which creates an object by copying variables from another object is called a copy constructor
         The purpose of a copy constructor is to initialize a new instance to the values of an existing instance
         we can say copy constructor is a constructor that copies the data of one object into another object.
             */
        int a;
        int b;
        public CopyConstructor(CopyConstructor copyConstructor)
        {
            a = copyConstructor.a;
            b = copyConstructor.b;
        }
        public CopyConstructor(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public string Details     // Get deatils of employee  
        {
            get
            {
                return " The age of " + a + " is " + b.ToString();
            }
        }

    }
}
