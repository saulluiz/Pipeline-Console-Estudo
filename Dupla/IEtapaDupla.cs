using System.Collections.Generic;
using System.Text;
using Pipeline.Simples;

namespace Pipeline.Dupla{


    public interface IEtapaDupla<T> : IEtapa<T>{
        IEtapaDupla<T> ProximaEtapa{get;set;}
    }
}