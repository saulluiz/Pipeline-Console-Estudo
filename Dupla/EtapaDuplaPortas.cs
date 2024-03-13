using System.Text;

namespace Pipeline.Dupla{
    public class EtapaDuplaPortas: IEtapaDupla<StringBuilder>{
             public IEtapaDupla<StringBuilder> ProximaEtapa{get;set;}

        public StringBuilder Processar(StringBuilder entrada){
            entrada.Insert(0,"[Portas]",2);
            entrada.Insert(entrada.Length,"[Portas]",2);
                        entrada=ProximaEtapa?.Processar(entrada) ?? entrada;
            int posPortasEsquerda= entrada.ToString().IndexOf("[Porta]");
            entrada.Insert(posPortasEsquerda,"Macaneta",2);
            int posPortasDireita= entrada.ToString().LastIndexOf("[Porta]");
            entrada.Insert(posPortasDireita,"Macaneta",2);

            return entrada;
        }
    }
}