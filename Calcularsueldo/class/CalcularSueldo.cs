
namespace CalcularSueldo.Class
{
    public class Calcular
    {
        public void CalcularSueldo()
        {
            //Declarar las variables horasTrabajadas,costoHoras,sueldo
            int horasTrabajadas = 0; 
            int costoHoras = 0; 
            decimal sueldo = 0;
            string Linea = string.Empty;

            Console.WriteLine("Digite las horas trabajadas: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el costo por horas");
            costoHoras = int.Parse(Console.ReadLine());


            sueldo = (horasTrabajadas * costoHoras);

            Console.WriteLine($"El sueldo es: {sueldo}");
        }

        public void CalcularProductoSuma()

        {
            //Declarar las variables del producto y la suma 
            int num1 = 0;
            int num2 = 0;
            decimal suma = 0;
            decimal producto = 0;


            Console.WriteLine("Digite el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = (num1 + num2);

            
            Console.WriteLine($"El suma es: {suma}");


            producto = (num1 * num2);

            Console.WriteLine($"El producto de la suma es: {producto}");


        }
    }
}
