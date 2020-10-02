using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiConectandoVidas.Model
{
    public class EtipoSangue
    {
        enum TipoSangue 
        {
            APositivo = 0,
            ANegativo = 1,
            BPositivo = 2,
            BNegativo = 3,
            ABositivo = 4,
            ABNegativo = 5,
            OBositivo = 6,
            ONegativo = 7
        }
    }
}
