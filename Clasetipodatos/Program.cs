using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Clasetipodatos
{
    internal class Program
    {

        static void Main(string[] args)
        {

       
            int horaprecio = 2000;
            double canthoras;
        

            //NOMBRE

            Console.WriteLine("Digite el nombre del epleado  :");
            string nombre = Console.ReadLine();

            //CEDULA
            Console.WriteLine("Digite la cedula de empleado  :");
            int cedula = int.Parse(Console.ReadLine());

            //HORAS
            Console.WriteLine("Digite las horas trabajas en la quincena :");
            int hora = int.Parse(Console.ReadLine());
            canthoras = horaprecio * hora;

            //SALARIO ORDINARIO
            Console.WriteLine("Digite el salario ordinario :");
            int salor = int.Parse(Console.ReadLine());

            //CCSS
            double ccss = 0.0934;
            


            //CODIGO EMPLEADO

            Console.WriteLine("Digite el codigo del empleado  :\n"+
            "(1) Operario:\n" +
            "(2) Técnico: \n" +
            "(3) Profesional: \n" +
            "Numero..?\n");


            string codigo = Console.ReadLine();
            double ope = 0.15;
            double tec = 0.10;
            double prf = 0.5;
          



            if (codigo.Equals("1"))
            {
               
               
                 double salbruto = salor * ope + salor;
                 double dedccss = salbruto * ccss;
                double salneto = salbruto - dedccss;

                Console.WriteLine("El aumento es de un 15% sobre el salario ordinario actual.:");
                Console.WriteLine("Los datos del empleado son los siguientes:");
                Console.WriteLine("Nombre del empleado :" + nombre);
                Console.WriteLine("Cedula :" + cedula);
                Console.WriteLine("Precio de la hora : " + horaprecio);
                Console.WriteLine("El monto a pagar por horas trabajadas: " + canthoras);
                Console.WriteLine("Cantidad de horas :" + hora);
                Console.WriteLine("Salario Bruto : " + salbruto);
                Console.WriteLine("Salario Neto : " + salneto);
                ope = int.Parse(Console.ReadLine());
            }
            else

            if (codigo.Equals("2"))
            {
                double salbruto = salor * tec + salor;
                double dedccss = salbruto * ccss;
                double salneto = salbruto - dedccss;

                Console.WriteLine("El aumento es de un 15% sobre el salario ordinario actual.:");
                Console.WriteLine("Los datos del empleado son los siguientes:");
                Console.WriteLine("Nombre del empleado :" + nombre);
                Console.WriteLine("Cedula :" + cedula);
                Console.WriteLine("Precio de la hora : " + horaprecio);
                Console.WriteLine("El monto a pagar por horas trabajadas: " + canthoras);
                Console.WriteLine("Cantidad de horas :" + hora);
                Console.WriteLine("Salario Bruto : " + salbruto);
                Console.WriteLine("Salario Neto : " + salneto);
                ope = int.Parse(Console.ReadLine());
            }
            else if
                (codigo.Equals("3"))

            {
                double salbruto = salor * prf + salor;
                double dedccss = salbruto * ccss;
                double salneto = salbruto - dedccss;

                Console.WriteLine("El aumento es de un 15% sobre el salario ordinario actual.:");
                Console.WriteLine("Los datos del empleado son los siguientes:");
                Console.WriteLine("Nombre del empleado :" + nombre);
                Console.WriteLine("Cedula :" + cedula);
                Console.WriteLine("Precio de la hora : " + horaprecio);
                Console.WriteLine("El monto a pagar por horas trabajadas: " + canthoras);
                Console.WriteLine("Cantidad de horas :" + hora);
                Console.WriteLine("Salario Bruto : " + salbruto);
                Console.WriteLine("Salario Neto : " + salneto);
                ope = int.Parse(Console.ReadLine());
            }
            else if
                (!codigo.Equals("1") || !codigo.Equals("2") || !codigo.Equals("3"))

            {
                Console.WriteLine("No es un codigo de empleado..!!");

            }
            //Console.WriteLine("El salario bruto es :"+(salor+codigo));

            // string toupper, tolower 







        }
    }
}

