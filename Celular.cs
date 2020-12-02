using System;

namespace Phone
{
    public class Celular
    {
        public string color = "azul";
        public string model = "iphone 13";
        public string size = "15cm";
        public bool on;

        public void ligar(){
            this.on = true;
        }

         public void desligar(){
           this.on = false;
    }

     public string fazerLigacao(){
            return "ligando";
    }
     public string enviarMensagem(){
            return "enviado";
    }


}
}