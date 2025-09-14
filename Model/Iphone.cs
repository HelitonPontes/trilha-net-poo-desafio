using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        private bool tiraFoto = false;
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string lojaApp, string nomeApp)
        {
            Console.WriteLine($"Entre na loja oficial: {lojaApp}. Nome APP: {nomeApp} ");
        }

        public void TirarFoto()
        {
            if (tiraFoto != true)
            {
                tiraFoto = true;
                Console.WriteLine("Ligar Camera");
            }
            else
            {
                tiraFoto = false;
                Console.WriteLine("Desligar Camera");
            }
        }
    }
}
