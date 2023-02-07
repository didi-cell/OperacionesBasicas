using System;
namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultSuma;
            int resultResta;
            int resultMultiplicar;
            int resultDivision;
            int resultResiduo;

            Console.WriteLine("PRIMER NÚMERO: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SEGUNDO NÚMERO");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultSuma = num1 + num2;
            resultResta = num1 - num2;  
            resultMultiplicar = num1 * num2;    
            resultDivision = num1 / num2;
            resultResiduo = num1 % num2;

            Console.WriteLine("LA SUMA ES: " + resultSuma);
            Console.WriteLine("LA RESTA ES: " + resultResta);
            Console.WriteLine("LA MULTIPLICACIÓN ES: " + resultMultiplicar);
            Console.WriteLine("LA DIVISIÓN ES: " + resultDivision);
            Console.WriteLine("EL RESIDUO ES:" + resultResiduo);
            Console.ReadKey();  //Se cierre la app al presionar tecla
        }
    }
}

