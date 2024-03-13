using System.Text;

namespace Pipeline.Dupla{
    public class EtapaDuplaPintura: IEtapaDupla<StringBuilder>{
                     public IEtapaDupla<StringBuilder> ProximaEtapa{get;set;}

        public StringBuilder Processar(StringBuilder entrada){

            entrada.Insert(0,"[Carroceria]",2);
            string[] cores= {"Preto","Branco","Prata","Vermelho","Grafite"};
            var ramdom= new Random();
            var corAleatoria = cores[ramdom.Next(0,cores.Length)];
            entrada.Insert(entrada.Length,$"[{corAleatoria}]",1);
            return entrada;
        }
    }
}