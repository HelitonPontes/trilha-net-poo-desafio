using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        protected bool ligar = false;
        
        private string modelo;

        private string imei;

        private int memoria;

        public Smartphone()
        {

        }

        public void InserirModelo(string modelo)
        {
            this.modelo = modelo;
            Console.WriteLine($"Modelo: {modelo}");
        }

        public void InserirImei(string imei)
        {
            this.imei = imei;
            Console.WriteLine($"Imei: {imei}");
        }

        public void InserirMemoria(int memoria)
        {
            this.memoria = memoria;
            Console.WriteLine($"Memoria: {memoria}");
        }


        public Smartphone(string numero)
        {
            Numero = numero;
            
        }
        // TODO: Passar os parâmetros do construtor para as propriedades
        protected Smartphone(string numero, string modelo, string imei, int memoria) : this(numero)
        {
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public void LigarAparelho()
        {
            if (ligar != true)
            {
                ligar = true;
                Console.WriteLine("Ligando Dispositivo");
            }
            else
            {
                ligar = false;
                Console.WriteLine("Desligando Dispositivo");

            }
         
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para o numero: {numero}");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo chamada do numero: {numero}");
        }

        public abstract void InstalarAplicativo(string lojaApp, string nomeApp);
    }
}
