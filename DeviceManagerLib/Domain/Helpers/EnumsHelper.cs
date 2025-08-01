namespace DeviceManagerLib.Domain.Helpers
{
    public class EnumsHelper
    {
        private static EnumsHelper? _instance;
        public static EnumsHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EnumsHelper();
                }

                return _instance;
            }
        }

        private EnumsHelper()
        {
        }

        public List<T> GetEnums<T>()
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .ToList();
        }
    }
}
