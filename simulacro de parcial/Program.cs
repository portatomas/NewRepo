namespace simulacro_de_parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio, generatriz, altura, area, volumen;
            Console.Write("ingrese el valor del radio " );
                radio=double.Parse(Console.ReadLine());
            Console.Write(" ingrese el valor de la altura " );
            altura = double.Parse(Console.ReadLine());
            generatriz = (calculargeneratris(radio, altura));
            area = calculararea(radio, generatriz);
            volumen = calcularvolumen(radio, altura);
            Console.WriteLine($"El área del cono es {area}");
            Console.WriteLine($"El volúmen del cono es {volumen}");
        }

        private static double calcularvolumen(double radio, double altura)
        {
            return (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        }

        private static double calculararea(double radio, double generatriz)
        {
            return Math.PI * radio * (radio + generatriz);
        }

        private static double calculargeneratris(double radio, double altura)
        {
            return Math.Sqrt(Math.Pow(radio, 2) + Math.Pow(altura, 2));
        }
    }
}