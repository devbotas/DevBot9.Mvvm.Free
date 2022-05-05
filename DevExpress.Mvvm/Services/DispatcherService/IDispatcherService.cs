using System;
using System.Threading.Tasks;

namespace DevBot9.Mvvm {
    public interface IDispatcherService {
        Task BeginInvoke(Action action);
        void Invoke(Action action);
    }
}
