using System.Text;

namespace Pipeline.Dupla{
    public class EtapaDuplaCarroceria: IEtapaDupla<StringBuilder>{
            public  IEtapaDupla<StringBuilder> ProximaEtapa{get;set;}

        public StringBuilder Processar(StringBuilder entrada){
            entrada.Insert(0,"[Carroceria]",2);
                        entrada=ProximaEtapa?.Processar(entrada) ?? entrada;

            return entrada;
        }
    }
}