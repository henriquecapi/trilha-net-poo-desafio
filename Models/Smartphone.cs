namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero){
            Numero = numero;
            Modelo = "Padrao";
            IMEI = "000000000000000000";
            Memoria = 0;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void EscreverNumero()
        {
            Console.WriteLine($"numero: {Numero}");
        }

        public void EscreverModelo()
        {
            Console.WriteLine("modelo: "+(Modelo));
        }

        public void EscreverImei()
        {
            Console.WriteLine("IMEI: "+(IMEI));
        }
        public void EscreverMemoria()
        {
            Console.WriteLine("memoria: "+(Memoria)+" KBytes");
        }

        public void TrocarNumero(Smartphone phone, string novoNumero)
        {
            phone.Numero = novoNumero;
        }

        public void TrocarImei(Smartphone phone, string novoImei)
        {
           phone.PegarImei(novoImei);
        }

         public void PegarImei(string imei)
        {
             this.IMEI = imei;
        }
        public string LerImei(Smartphone smart)
        {
            return smart.IMEI;
        }
        public string LerNumero(Smartphone smart)
        {
            return smart.Numero;
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        
    }
}