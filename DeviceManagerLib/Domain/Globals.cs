using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManagerLib.Domain
{
    public class Globals
    {
        private static Globals _instance;
        public static Globals Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Globals();
                }
                return _instance;
            }
        }

        private int _nextFreeId;

        public int GetNextFreeDeviceId()
        {
            return ++_nextFreeId;
        }
    }
}
