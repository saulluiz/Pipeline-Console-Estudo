using System.Collections.Generic;
namespace Pipeline.Simples{


    public interface IEtapa<T>{
      public  T Processar(T entrada);
    }
}