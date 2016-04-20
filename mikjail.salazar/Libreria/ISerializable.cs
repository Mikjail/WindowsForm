using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    interface ISerializable
    {
        Boolean Deserealizar(string ruta);
        Boolean Serealizar(string ruta);
    }
}
