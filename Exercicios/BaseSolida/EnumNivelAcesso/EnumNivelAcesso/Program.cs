using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNivelAcesso
{
    enum NivelAcesso
    {
        Leitura = 1,
        Escrita = 2,
        Admin = 3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NivelAcesso nivelAcessoPerfil = NivelAcesso.Admin;
            Console.WriteLine($"Seu Nível de Acesso é: {nivelAcessoPerfil} - Número: {(int)nivelAcessoPerfil}");
        }
    }
}
