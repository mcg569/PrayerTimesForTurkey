using System.Net.NetworkInformation;

namespace MuslimWidget
{
  public static class NetworkControl
    {
        public static bool NetworkConnection()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

    }
}
