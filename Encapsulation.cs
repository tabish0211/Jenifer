using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeniferConsoleApplication
{
    public class Encapsulation
    {
        //it is not accessible outside class directly
        private int _cutomerId;

        public int CustomerId
        {
            get {
            
                return _cutomerId;

            }
            set{
            
                _cutomerId=value;
            
            }

        }

        //public void SetData(int id)
        //{

        //    _cutomerId = id;

        //}

        //public int GetData() {

        //    return _cutomerId;
        //}

    }


    public class CallEncapsulatedData {

        static void Main() {

            Encapsulation obj = new Encapsulation();
            //obj.SetData(101);
            //int res=obj.GetData();
            //Console.WriteLine(res);

            obj.CustomerId = 101;
            Console.WriteLine(obj.CustomerId);
            Console.ReadLine();

        }
    
    }
}
