using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Class
{

    // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// abstract class tutorial
    /// </summary>

    public abstract class abstracclassSample
    {
        //abstract method not able to create private access modifier
        // we can able to create abstract constructor that will initialize creation of object and derived class
        public abstracclassSample()
        {
            
        
        }
        public abstract void Runsample();
        public string sample()
        {
            return "sample";
        }
    }
    abstract class abstracclassSample2
    {
        //abstract method not able to create private access modifier
        public abstract void Runsample2();
        public string sample2()
        {
            return "sample 2";
        }
    }
    // * we cannot able to create object of the abstract class
    // abstracclassSample obj = new abstracclassSample();
    // we can create contructor of the abstract class
    //
    // when we declare abstact class without access specifier  it will thorw error inconsistent accessibility error while inheriting to derived class like abstracclasssample2 class
    public class Sample3 : abstracclassSample
    {
        public Sample3()
        {

        }
        public override void Runsample()
        {
            throw new NotImplementedException();
        }
    }

}
