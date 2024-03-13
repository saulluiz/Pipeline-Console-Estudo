using System.Text;

namespace Pipeline.Dupla{
    public class EtapaDuplaBancos: IEtapaDupla<StringBuilder>{
           public IEtapaDupla<StringBuilder> ProximaEtapa{get;set;}

        public StringBuilder Processar(StringBuilder entrada){
            entrada.Insert(0,"[Bancos]",2);
            entrada.Insert(entrada.Length,"[Bancos]",2);
            entrada=ProximaEtapa?.Processar(entrada) ?? entrada;
            return entrada;
        }
    }
}