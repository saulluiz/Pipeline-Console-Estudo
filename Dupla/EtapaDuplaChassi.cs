using System.Text;

namespace Pipeline.Dupla{
    public class EtapaDuplaChassi: IEtapaDupla<StringBuilder>{
             public IEtapaDupla<StringBuilder> ProximaEtapa{get;set;}

        public StringBuilder Processar(StringBuilder entrada){
            entrada.Append("[CHASSI]");
                        entrada=ProximaEtapa?.Processar(entrada) ?? entrada;

            return entrada;
        }
    }
}