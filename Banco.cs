using System;

namespace DelegadosEventos_Banco_G2_2022_II
{
    class Banco
    {
        private string nombre;
        public delegate void DelegadoValidaUsuario();
        public event DelegadoValidaUsuario ValidaUsuario;

        public delegate void DelegadoOperacion(int operacion);
        public event DelegadoOperacion Operacion;

        public void Mensaje(string Nombre)
        {
            Console.WriteLine("Bienvenido {0} a la red de tu banco ", Nombre);
            nombre = Nombre;
        }

        public void DisparaValida()
        {
            if( nombre != "Armando")
            {
                Console.WriteLine("El usuario no está en el sistema");
                ValidaUsuario();
            }else
            {
                Console.WriteLine("Proceder a las siguientes operaciones \n 1)Consultar estado de cuenta \n 2)Retirar ");
                int operacion = int.Parse(Console.ReadLine());
                Operacion(operacion);

            }
        }



    }
}
