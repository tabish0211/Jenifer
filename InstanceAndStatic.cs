using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeniferConsoleApplication
{
    public class InstanceAndStatic
    {
        public int Id;//Instance variable
        public static int counter;//static varaibles are not the part of instance/object
       //Instance Methods
        public void SetData() {

            Id = 1;
            counter = 2;
        
        }

        public int GetData() {

            return Id;
        
        }

        public static void IamStatic() {
            InstanceAndStatic obj = new InstanceAndStatic();
            obj.Id = 5;
            counter = 3;
            
        
        }
        //static void Main() {

        //    InstanceAndStatic obj = new InstanceAndStatic();
        //    Console.WriteLine(counter);
        //    Console.WriteLine(obj.Id);          
            
        
        //}
    }

    public class DemoStaicNonStaticCalls {

        public void CallVariables()
        {
            InstanceAndStatic obj = new InstanceAndStatic();
            Console.WriteLine(obj.Id);
            Console.WriteLine(InstanceAndStatic.counter);

        }

        public void CallMethods()
        {
            InstanceAndStatic obj = new InstanceAndStatic();
            obj.SetData();

            InstanceAndStatic.IamStatic();

        }
    

    }
}
