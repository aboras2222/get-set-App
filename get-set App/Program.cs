using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_set_App
{
   class Monster
    {
       private int _Power = 1000;
        public int Power
        {

            get
            {
                return (_Power);
            }

            set
            {
                if (value <= 0)
                {
                    _Power = 0;
                }
                else if (value > 1000)
                {
                    _Power = 1000;
                }
                else
                {
                    _Power = value;
                }
            }

        }










    }

            
        
        
        
      
        

          



        



    





    class Program
    {
        static void Main(string[] args)
        {
            Monster poos = new Monster();
            poos.Power += 120;
            Console.WriteLine(poos.Power);

            Console.ReadKey();
        }
    }
}
