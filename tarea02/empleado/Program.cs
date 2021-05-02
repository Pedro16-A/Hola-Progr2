using System;

namespace empleado
{
    class Program
    {
        static void Main(string[] args){

            Empleado empleado1 = new Empleado("Pedro Silva",28256628,"control de calidad",200);

            Console.WriteLine(empleado1.getInfoempleado());
        
        }
    }

    class Empleado{
        public Empleado(string nombre1,int cedula1,string departamento1,int salario1){
            nombre = nombre1;
            cedula = cedula1;
            departamento = departamento1;
            salario = salario1;
        }

        public String getInfoempleado(){

            return " Informacion del empleado: " + nombre + "Cedula " + cedula + "Departamento " + departamento + "Salario " + salario;

        }

        private String nombre;
        private int cedula;

        private String departamento;

        private int salario;
        }
}
