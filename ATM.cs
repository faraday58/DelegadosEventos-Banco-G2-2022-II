using System;


namespace DelegadosEventos_Banco_G2_2022_II
{
    class ATM
    {
        private delegate void MensajeDelegado(string Dato);

        public static void MensajeErrorValida()
        {
            Console.WriteLine(" Es posible que ingresaras un usuario incorrecto " );
         }


        public static void MensajeOperacion(int opcion)
        {
            switch(opcion )
            {
                case 1:
                    Console.WriteLine("Por el momento no puedo realizar la operación");
                    break;
                case 2:
                    Console.WriteLine("1) 100 \n 2) 200 \n 3) 300 \n 4) 5000 ");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Banco miBanco = new Banco();
            miBanco.ValidaUsuario += MensajeErrorValida; //Suscribiendo Método a un Evento
            miBanco.Operacion += MensajeOperacion;
                                            //Método que cumple con la firma del delegado
            MensajeDelegado miDelegado = new MensajeDelegado( miBanco.Mensaje );
            Console.WriteLine("Escribe tu nombre de usuario ");
            string nombre = Console.ReadLine();
            miDelegado(nombre);


            Random funcionAleatoria = new Random();

            int funciona = funcionAleatoria.Next(2);

            if( funciona == 1)
            {
                miBanco.DisparaValida();
            }else
            {
                miBanco.Operacion -= MensajeOperacion;
                try
                {
                    miBanco.DisparaValida();
                }
                catch(NullReferenceException error)
                {
                    Console.WriteLine("Por el momento no cuento con efectivo");
                }
            }


           
            




            miDelegado = new MensajeDelegado(SPEI.MensajeSPEI);
            miDelegado(DateTime.Now.ToString("d/MM/y  hh:mm"));


            Console.ReadLine();
            

        }
    }
}
