
namespace Bev.IO.RemoteInterface
{
    public interface IRemoteInterface
    {
        void Output(int address, string command);

        string Enter(int address);

        void Remote(int address);

        void Local(int address);

        void Trigger(int address);
    }
}
