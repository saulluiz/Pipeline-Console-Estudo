using System.Text;

namespace Pipeline.Simples{
    public class EtapaPortas: IEtapa<StringBuilder>{
        public StringBuilder Processar(StringBuilder entrada){
            entrada.Insert(0,"[Portas]",2);
            entrada.Insert(entrada.Length,"[Portas]",2);
            return entrada;
        }
    }
}