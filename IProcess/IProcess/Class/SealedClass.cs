using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Class
{
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    /*\
        Sealed class implementation

    *A Sealed class is a class  that cannot be inherited and used to restrict the properties.
    * Access modifiers are not applied to a sealed clas
    * To access the sealed members we must create an object of the class
    * sealed class can access the public and internal access specifier
    * we can create object of the sealed class
    * 
     */

    public sealed class sealedSample
    {
        public string samplestring = "";

        public sealedSample()
        {
        }
        public string ssamplemethod()
        {
            return "test";
        }

    }
}
