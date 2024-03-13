using System.Text;

namespace Pipeline.Dupla{
    public class EtapaDuplaMotor: IEtapaDupla<StringBuilder>{
                     public IEtapaDupla<StringBuilder> ProximaEtapa{get;set;}

        public StringBuilder Processar(StringBuilder entrada){
            entrada.Append("[Motor]");
                        entrada=ProximaEtapa?.Processar(entrada) ?? entrada;

            return entrada;
        }
    }
}