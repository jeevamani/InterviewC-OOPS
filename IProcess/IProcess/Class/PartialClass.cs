using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Class
{
    /*
    Partial class implementation
    */

    // first class we declare in normal
    // second class with same name we declare in partial key word  then first declare class will throw the error missing partial keyword error
    // if one partial class declare as a sealed class then all the class  made  sealed then we can't ablet to inherit partial class
    // 

    public partial class partialclasssample
    {


        public string psample()
        {
            return "partial return";
        }
    }

    public partial class partialclasssample : psample
    {

        public string psample2()
        {
            return "partial class implemted";
        }
    }

    public class psample
    {
        public void psample23()
        {

        }
    }
}
