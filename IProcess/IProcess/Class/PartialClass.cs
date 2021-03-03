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
        public partialclasssample()
        {

        }

        public void psample()
        {
            Console.WriteLine("partial return");
            Console.ReadLine();
        }
    }

    public partial class partialclasssample : psample
    {
        public partialclasssample(int a)
        {

        }

        public void psample2()
        {
            Console.WriteLine("partial class implemted");
            Console.ReadLine();
           
        }
    }

    public class psample
    {
        public void psample23()
        {

        }
    }
}
