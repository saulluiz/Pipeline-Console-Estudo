using System.Text;

namespace Pipeline.Simples{
    public class EtapaCarroceria: IEtapa<StringBuilder>{
        public StringBuilder Processar(StringBuilder entrada){
            entrada.Insert(0,"[Carroceria]",2);
            return entrada;
        }
    }
}