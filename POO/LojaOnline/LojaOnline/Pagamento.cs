using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    abstract class Pagamento
    {
        public abstract bool ProcessarPagamento(decimal valor);
    }
}
