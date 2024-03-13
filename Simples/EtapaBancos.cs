using System.Text;

namespace Pipeline.Simples{
    public class EtapaBancos: IEtapa<StringBuilder>{
        public StringBuilder Processar(StringBuilder entrada){
            entrada.Insert(0,"[Bancos]",2);
            entrada.Insert(entrada.Length,"[Bancos]",2);
            return entrada;
        }
    }
}