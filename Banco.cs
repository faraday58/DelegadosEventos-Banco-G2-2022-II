using System;

namespace DelegadosEventos_Banco_G2_2022_II
{
    class Banco
    {
        private string nombre;



        public void Mensaje(string Nombre)
        {
            Console.WriteLine("Bienvenido {0} a la red de tu banco ", Nombre);
            nombre = Nombre;

        }

    }
}
