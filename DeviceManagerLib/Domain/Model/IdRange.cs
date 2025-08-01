using DeviceManagerLib.Domain.Helpers;

namespace DeviceManagerLib.Domain.Model
{
    public class IdRange
    {
        private int _currentId;
        public IdRange(int initialId, int finalId)
        {
            InitialId = initialId;
            FinalId = finalId;
            _currentId = initialId;
        }

        public int InitialId { get; }
        public int FinalId { get; }

        public int NextId()
        {
            if (_currentId > FinalId)
                throw new Exception(ExceptionMessagesHelper.Instance.IdRangeDepleted());

            return _currentId++;
        }
    }
}
