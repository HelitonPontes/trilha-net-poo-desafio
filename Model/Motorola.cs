using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Motorola : Smartphone
    {
        public string  PegouFogo()
        {
            return "Pegou fogo o Smartfone";
        }
        public override void InstalarAplicativo(string lojaApp, string nomeApp)
        {
            Console.WriteLine($"Entre na loja oficial: {lojaApp}. Nome APP: {nomeApp} ");
        }
    }
}
