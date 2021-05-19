using System;
namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor = "Preto";
        public string modelo = "Samsung Serenata";
        public float tamanho = 2.26f;
        public bool ligado;
        public string msg;

        public bool Ligar()
        {
            return ligado = true;
        }
        public bool Desligar()
        {
            return ligado = false;
        }

        public string Fazerligação()
        {
            
            return "Fazendo ligação";
        }

        public string Enviarmsg()
        {
            Console.WriteLine("Digite uma mensagem");
            msg = Console.ReadLine(); 

            return "Enviando mensagem";
        }
    }


}