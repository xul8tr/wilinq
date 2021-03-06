using System;

namespace WiLinq.LinqProvider.Wiql
{
    public sealed class StringValueStatement : ValueStatement
    {
        /// <summary>
        ///     Initializes a new instance of the StringValueStatement class.
        /// </summary>
        internal StringValueStatement(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "value");
            }
            Value = value;
        }

        internal StringValueStatement() : this(string.Empty)
        {
        }

        public string Value { get; }


        private string Quote(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("value is null or empty.", nameof(value));
            }

            return value.Replace("'", "''");
        }

        protected internal override string ConvertToQueryValue()
        {
            return $"'{Quote(Value)}'";
        }

        public override ValueStatement Clone()
        {
            return new StringValueStatement(Value);
        }
    }
}