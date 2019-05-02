using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3React1.Clases
{
    class Cat : Interface1
    {
        public string talk()
        {
            return "meoooowwww";
        }

        public string Name(AnimalData data) //ASOCIACIONM
        {
            return data.getName();
        }
       
        
    }
}
