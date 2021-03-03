using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.DesignPattern.Creational
{
    /*
     This pattern ensures that the class has only one instance and provides a global point of access to it
     The pattern ensures that only one object of a specific class is ever created
     All further references to objects of the singleton class refer to the same underlying instance.
     In the singleton pattern, all the methods and instances are defined as static
     The static keyword ensures that only one instance of the object is created and you can call methods of the class without creating an object.
     The constructor of a class is marked as private. This prevents any external classes from creating new instances.
     The class is also sealed to prevent inheritance, which could lead to subclassing that breaks the singleton rules.
         */
   public class SingletonDesignPattern
    {
        // earlier initialization of singleton pattern
        private static SingletonDesignPattern instance = new SingletonDesignPattern();
        private SingletonDesignPattern()
        {

        }

        public static SingletonDesignPattern GetInstance
        {
            get
            {
                return instance;
            }
        }

        // Lazy  initialization of singleton pattern
        private static SingletonDesignPattern instance1 = null;
        

        public static SingletonDesignPattern GetInstance1
        {
            get
            {
                if(instance1 == null)
                {
                     instance1 = new SingletonDesignPattern();
                }
                return instance1;
            }
        }

        //Thread-safe(Double-checked Locking) initialization of singleton pattern

        private static SingletonDesignPattern instance2 = null;
        public static object lockThis = new object();
        public static SingletonDesignPattern GetInstance2
        {
            get
            {
                lock (lockThis)
                {
                    if (instance1 == null)
                    {
                        instance1 = new SingletonDesignPattern();
                    }
                    return instance1;
                }
            }
        }
    }
}
