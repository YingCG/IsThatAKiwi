using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsKiwiApp
{
    class Picture
    {
        public bool IsKiwi { get; set; }
        
        public Picture(int index)
        {
            //int result = new Random().Next(1, 3);
            this.IsKiwi = (index == 1) ? true : false;
        }
        public void checkKiwi(int index)
        {
            //Random r = new Random();
            //int result = new Random().Next(1, 3);
            

                if (index == 1)
                {
                    this.IsKiwi = true;
                }
                else
                {
                    this.IsKiwi = false;
                }
            
        }
    }
}
