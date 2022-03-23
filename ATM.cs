using System;


namespace DelegadosEventos_Banco_G2_2022_II
{
    class ATM
    {
        private delegate void MensajeDelegado(string Dato);

        static void Main(string[] args)
        {
            Banco miBanco = new Banco();
                                            //Método que cumple con la firma del delegado
            MensajeDelegado miDelegado = new MensajeDelegado( miBanco.Mensaje );
            Console.WriteLine("Escribe tu nombre de usuario ");
            string nombre = Console.ReadLine();
            miDelegado(nombre);

            miDelegado = new MensajeDelegado(SPEI.MensajeSPEI);
            miDelegado(DateTime.Now.ToString("d/MM/y  hh:mm"));


            Console.ReadLine();
            

        }
    }
}
