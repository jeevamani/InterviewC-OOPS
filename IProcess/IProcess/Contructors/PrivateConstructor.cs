using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Contructors
{
    /*
     When a constructor is created with a private specifier, it is not possible for other classes to derive from this class
     It provides an implementation of a singleton class pattern

     Once we provide a constructor that is either private or public or any, the compiler will not add the parameter-less public constructor to the class

        One use of a private constructor is when we have only static members
         */
    class PrivateConstructor
    {
        private PrivateConstructor()
        {

        }

        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }
    }
}
