
namespace DevBot9.Mvvm {
    public interface ILockable {
        void BeginUpdate();
        void EndUpdate();
        bool IsLockUpdate { get; }
    }
}
