using System;

namespace Phone
{
    public class Celular
    {
        public string color = "azul";
        public string model = "iphone 13";
        public string size = "15cm";
        public bool on = false;

        public void Ligar(){
            this.on = true;
        }

         public void Desligar(){
           this.on = false;
    }

     public void FazerLigacao(){
            Console.WriteLine("Ligando...");
    }
     public void EnviarMensagem(){
            Console.WriteLine("Enviando mensagem...");
    }


}
}