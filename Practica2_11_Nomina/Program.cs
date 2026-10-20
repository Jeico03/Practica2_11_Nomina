namespace Practica2_11_Nomina
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.WriteLine("Ingrese el nombre del empleado:");

          string nombre = Console.ReadLine();

          Console.WriteLine("Ingrese las horas trabajadas:");

          int horasTrabajadas = int.Parse(Console.ReadLine());

          Console.WriteLine("Ingrese el pago por hora:");

          decimal pagoPorHora = decimal.Parse(Console.ReadLine());

          decimal salarioBruto = horasTrabajadas * pagoPorHora;

            Console.WriteLine($"\n==============================\n      RESUMEN DE NÓMINA\n==============================");
            Console.WriteLine($"Empleado: {nombre}");
            Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
            Console.WriteLine($"Pago por hora: RD${pagoPorHora:N2}");
            Console.WriteLine($"Salario Bruto: RD${salarioBruto:N2}");
            Console.WriteLine($"==============================");

        }
    }
}