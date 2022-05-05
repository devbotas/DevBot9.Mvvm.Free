using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DevBot9.Mvvm.Native;
using System.Windows.Threading;

namespace DevBot9.Mvvm.Native {
    public class StrongReferenceActionInvokerFactory : IActionInvokerFactory {
        IActionInvoker IActionInvokerFactory.CreateActionInvoker<TMessage>(object recipient, Action<TMessage> action) {
            return new StrongReferenceActionInvoker<TMessage>(recipient, action);
        }
    }
    public class WeakReferenceActionInvokerFactory : IActionInvokerFactory {
        IActionInvoker IActionInvokerFactory.CreateActionInvoker<TMessage>(object recipient, Action<TMessage> action) {
            if(action.Method.IsStatic)
                return new StrongReferenceActionInvoker<TMessage>(recipient, action);
            return new WeakReferenceActionInvoker<TMessage>(recipient, action);
        }
    }
}
