using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPersonagensRPG
{
    internal interface IAtaque
    {
        void ExecutarAtaque(Personagem alvo);
    }
}
