using System;

namespace Ordem_inversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int[15];

            for(var i=0; i<15; i++){
            Console.WriteLine("Digite um numeros");
            numeros[i] = int.Parse(Console.ReadLine());

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            for(var i=14; i>0;i--){
            Console.WriteLine(numeros[i]);

            }
        }
    }
}
