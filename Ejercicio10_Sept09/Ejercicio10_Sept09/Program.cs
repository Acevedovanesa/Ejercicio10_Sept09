using System.ComponentModel.Design;

public class Program
{
    public static void Main(string[] args)
    {
        double num1, num2, num3;
        double Mayor, Menor, Medio;


        Console.Write("Ingrese el Numero 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el Numero 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el Numero 3: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        if (num1 > num2 && num1 > num3) {
            Mayor = num1;
            if (num2 > num3) {

                Medio = num2;
                Menor = num3;

            } else  {
                Medio = num3;
                Menor = num2;
            }
        } else if (num2 > num1 && num2 > num3) {
            Mayor = num2;
            if (num1 > num3) {
                Medio = num1;
                Menor = num3;

            } 
        } else {
            Medio = num3;
            Menor = num1;
        }
        else
        { 
       
        
            Mayor = num3;
            if (num1 > num2)
            {
                Medio = num1;
                Menor = num2;

            }
            else
            {
                Medio = num2;
                Menor = num1;
            }
            Console.WriteLine("El numero Mayor es: " + Mayor);
            Console.WriteLine("el Mayor es: " + Medio);
            Console.WriteLine("el Mayor es: " + Menor);

        }

       


    }

}









