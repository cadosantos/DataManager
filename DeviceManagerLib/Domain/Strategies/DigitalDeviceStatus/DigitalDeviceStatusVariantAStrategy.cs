using DeviceManagerLib.Domain.Helpers;
using DeviceManagerLib.Domain.Interfaces;

namespace DeviceManagerLib.Domain.Strategies.DigitalDeviceStatus
{
    public class DigitalDeviceStatusVariantAStrategy : IDigitalDeviceStatusStrategy
    {
        public DigitalDeviceStatusVariantAStrategy()
        {
            GenerateValueFunc = GenerateRandomDecimalWithinRange;
        }

        public Func<decimal> GenerateValueFunc { get; set; }

        const decimal LowerBound = -50.0m;
        const decimal UpperBound = 70.0m;

        public string GenerateStatus()
        {
            return GenerateStatus(GenerateValueFunc());
        }

        private string GenerateStatus(decimal value)
        {
            if (value < LowerBound || value > UpperBound)
                throw new ArgumentOutOfRangeException(ExceptionMessagesHelper.Instance.ValueOutOfBounds(FormatDecimalValue(LowerBound), FormatDecimalValue(UpperBound)));

            switch (value)
            {
                case LowerBound:
                    return "Low";
                case UpperBound:
                    return "High";
                default:
                    var formattedDecimalValue = FormatDecimalValue(value);
                    if (value > 0)
                    {
                        return $"+{formattedDecimalValue}";
                    }

                    return formattedDecimalValue;
            }
        }

        private static string FormatDecimalValue(decimal value)
        {
            return $"{value:F1}";
        }

        private decimal GenerateRandomDecimalWithinRange()
        {
            Random random = new Random();
            decimal range = UpperBound - LowerBound;
            decimal decimalMultiplier = (decimal)random.NextDouble();
            return LowerBound + decimalMultiplier * range;
        }
    }
}
