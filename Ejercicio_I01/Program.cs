using Entidades;
namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Cuenta cuenta_nueva = new Cuenta("pablo", 100);
            Console.WriteLine(cuenta_nueva.Mostrar());
            cuenta_nueva.Retirar(50);
            Console.WriteLine(cuenta_nueva.Mostrar());
            cuenta_nueva.Ingresar(200);
            Console.WriteLine(cuenta_nueva.Mostrar());
        }
    }
}