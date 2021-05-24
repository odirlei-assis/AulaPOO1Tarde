using System;

namespace ExemploPOO1Tarde.Classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now.Date;

        protected float Valor = 2599f;

        public string Cancelar(){
            return "Pagamento Cancelado";
        }
    }
}