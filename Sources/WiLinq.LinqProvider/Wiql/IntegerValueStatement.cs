using System.Globalization;

namespace WiLinq.LinqProvider.Wiql
{
    public sealed class IntegerValueStatement : ValueStatement
    {
        internal IntegerValueStatement(long value)
        {
            Value = value;
        }

        public long Value { get; }

        protected internal override string ConvertToQueryValue()
        {
            return Value.ToString("D",CultureInfo.InvariantCulture);
        }

        public override ValueStatement Clone()
        {
            return new IntegerValueStatement(Value);
        }
    }
}