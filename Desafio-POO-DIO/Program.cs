using Model;
using System;

namespace Desafio_POO_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Realizar os testes com as classes Nokia e Iphone
            Console.WriteLine("");
            Console.WriteLine("Nokia");
            Console.WriteLine();
            Nokia nokia = new Nokia();
            nokia.InserirModelo("Smartphone Nokia 5.4 Nk025");
            nokia.InserirImei("111111111");
            nokia.InserirMemoria(128);
            nokia.LigarAparelho();
            nokia.JogoCobrinha();
            nokia.JogoCobrinha();
            nokia.Ligar("(15)5555555");
            nokia.ReceberLigacao("(11)9874562214");          
            nokia.InstalarAplicativo("Play Store", "TikTok");
            nokia.LigarAparelho();
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________");

            Console.WriteLine("");
            Console.WriteLine("Iphone");
            Console.WriteLine();
            Iphone iphone = new Iphone();
            iphone.InserirModelo("Apple iPhone 16 Pro – Titânio preto");
            iphone.InserirImei("222222222");
            iphone.InserirMemoria(256);
            iphone.LigarAparelho();
            iphone.TirarFoto();
            iphone.TirarFoto();
            iphone.Ligar("(15)5555555");
            iphone.ReceberLigacao("(11)9874562214");
            iphone.InstalarAplicativo("APP Store", "TikTok");
            iphone.LigarAparelho();
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________");

            Console.WriteLine("");
            Console.WriteLine("Motorola");
            Console.WriteLine();
            Motorola motorola = new Motorola();
            motorola.InserirModelo("Smartphone Motorola Edge 50 Neo 5G ");
            motorola.InserirImei("33333333333333333");
            motorola.InserirMemoria(256);
            motorola.LigarAparelho();
            motorola.Ligar("(15)5555555");
            motorola.ReceberLigacao("(11)9874562214");
            motorola.InstalarAplicativo("Play Store", "TikTok");
            motorola.LigarAparelho();
            Console.WriteLine(motorola.PegouFogo()); 
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________");

            Console.WriteLine("");
            Console.WriteLine("Sansung");
            Console.WriteLine();
            Sansung sansung = new Sansung();
            sansung.InserirModelo("Celular Samsung Galaxy S25+ 5G");
            sansung.InserirImei("444444444444444");
            sansung.InserirMemoria(512);
            sansung.LigarAparelho();
            sansung.Ligar("(15)5555555");
            sansung.ReceberLigacao("(11)9874562214");
            sansung.InstalarAplicativo("Sandung  Store", "TikTok");
            sansung.LigarAparelho();
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________");





        }
    }
}
