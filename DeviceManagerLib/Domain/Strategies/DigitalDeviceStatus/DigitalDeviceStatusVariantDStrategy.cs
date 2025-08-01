using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus
{
    public abstract class DigitalDeviceStatusVariantDStrategy : IDigitalDeviceStatusStrategy
    {
        protected DigitalDeviceStatusVariantDStrategy()
        {
            GenerateValueFunc = GenerateRandomIntegerWithinRange;
        }

        public Func<int> GenerateValueFunc { get; set; }

        const int LowerBound = 0;
        const int UpperBound = 100;

        protected abstract int Step { get; }

        public string GenerateStatus()
        {
            return GenerateStatus(GenerateValueFunc());
        }

        private string GenerateStatus(int value)
        {
            if (value < LowerBound || value > UpperBound)
                throw new ArgumentOutOfRangeException(nameof(value), ExceptionMessagesHelper.ValueOutOfBounds(LowerBound.ToString(), UpperBound.ToString()));

            if (value % Step != 0)
                throw new ArgumentOutOfRangeException(nameof(value), ExceptionMessagesHelper.ValueInvalidForStep(Step));

            switch (value)
            {
                case LowerBound:
                    return "Opened";
                case UpperBound:
                    return "Closed";
                default:
                    return $"{value}%";
            }
        }

        private int GenerateRandomIntegerWithinRange()
        {
            var range = UpperBound - LowerBound;
            var possibleNumbersCount = range / Step + 1;

            return LowerBound + Random.Shared.Next(LowerBound, possibleNumbersCount) * Step;
        }
    }
}
