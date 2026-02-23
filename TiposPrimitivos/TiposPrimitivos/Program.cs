using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 2; // == System.Int32
            double realGrande; // == System.Double
            bool booleano; // == System.Boolean
            string texto; // == System.String

            // Cada tipo primitivo tem um operador
            // Números:
            int resultado;
            resultado = inteiro + inteiro;
            resultado = inteiro - inteiro;
            resultado = inteiro * inteiro;
            resultado = inteiro / inteiro;
            resultado = inteiro % inteiro;

            // Booleanos
            bool comparacao;
            comparacao = inteiro == inteiro;
            comparacao = inteiro > inteiro;
            comparacao = inteiro != inteiro;
            comparacao = inteiro <= inteiro;

            // Lógicos
            bool condicao;
            condicao = true && false; // AND
            condicao = true || false; // OR
            condicao = !true; // NOT
        }
    }
}
