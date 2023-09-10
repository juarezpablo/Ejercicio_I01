using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;
        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Cantidad: {this.cantidad}");
            return sb.ToString();
        }

        public void Ingresar(int cantidad)
        {
            if(cantidad >=0)
            {
                this.cantidad=this.cantidad+cantidad;
            }
        }

        public void Retirar(int monto)
        {
            this.cantidad = this.cantidad - monto;
        }
    }
}