using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBot9.Mvvm.Native {
    public interface IApplicationJumpTaskInfoSource : IApplicationJumpItemInfoSource {
        Action Action { get; }
    }
}
