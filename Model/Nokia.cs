using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // TODO: Herdar da classe "Smartphone
    public class Nokia : Smartphone
    {
        private bool jogocobrinha = false;

        public void JogoCobrinha()
        {
            if ( jogocobrinha == false)
            {
                jogocobrinha = true;
                Console.WriteLine("Vamos jpgar");  
            }
            else
            {
                jogocobrinha = false;
                Console.WriteLine("Jogo Finalizado");

            }
        }


       

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string lojaApp,string nomeApp)
        {
            Console.WriteLine($"Entre na loja oficial: {lojaApp}. Nome APP: {nomeApp} ");
            
        }
    }
}
