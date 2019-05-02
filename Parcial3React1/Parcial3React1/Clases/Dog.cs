using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3React1.Clases
{
    class Dog : Interface1
    {
        public string talk()
        {
            return "guaaaaauuuu auuuu";
        }

        public string name(AnimalData data) // ASOSIACION
        {
            return data.getName();
        }
    }
}
