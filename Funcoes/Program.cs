using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //funções ou procedimentos

            Console.WriteLine("Selecione qual forma geometrica voce gostaria de medir: Quadrado, Retângulo, Trapézio, Losango");
            string figura = Console.ReadLine();
            figura.ToLower();

            switch (figura)
            {

                case "quadrado":
                    quadrado();
                    break;
                case "retangulo":
                    retangulo();
                    break;
                case "trapezio":
                    trapezio();
                    break;
                case "losango":
                    losango();
                    break;
            }

            Console.ReadKey();
        }

        static void quadrado()
        {
            Console.WriteLine("Digite o tamanho do lado do quadrado: ");
            int lado = int.Parse(Console.ReadLine());
            int quadrado = lado * lado;
            Console.WriteLine("A area do quadrado é de: " + quadrado);
        }

        static void retangulo()
        {
            Console.WriteLine("Digite a altura do retângulo: ");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a medida da base do retângulo: ");
            int basee = int.Parse(Console.ReadLine());
            int retangulo = basee * altura;
            Console.WriteLine("A area do retângulo é de: " + retangulo);
        }

        static void trapezio()
        {
            Console.WriteLine("Digite a medida da base maior do trapézio: ");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a medida da base menor do trapézio: ");
            int base2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do trapézio: ");
            int alto = int.Parse(Console.ReadLine());
            int trape = ((base1 + base2) * alto) / 2;
            Console.WriteLine("A area do trapézio é de: " + trape);
        }

        static void losango()
        {
            Console.WriteLine("Digite a medida da diagonal maior do losango: ");
            int diago1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a medida da diagonal menor do losango: ");
            int diago2 = int.Parse(Console.ReadLine());
            int losango = (diago1 * diago2) / 2;
            Console.WriteLine("A area do trapézio é de: " + losango);
        }
    }
}
