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
        
        public Picture(bool k)
        {
            this.IsKiwi = k;
        }
        public void checkKiwi(Random drawPic)
        {
            //Random r = new Random();
            int result = drawPic.Next(1,3);
            {
                if (result == 1)
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
}
