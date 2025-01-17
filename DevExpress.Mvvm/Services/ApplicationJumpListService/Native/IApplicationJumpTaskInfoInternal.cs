using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBot9.Mvvm.Native {
    public interface IApplicationJumpTaskInfoInternal : IApplicationJumpItemInfoInternal {
        void Execute();
        bool IsInitialized { get; }
        void SetAutoGeneratedCommandId(string commandID);
    }
}
