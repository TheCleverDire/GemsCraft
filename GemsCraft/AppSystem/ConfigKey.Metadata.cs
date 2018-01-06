using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace GemsCraft.AppSystem
{
    /// <summary>
    /// Describes attributes and metadata of a configuration key
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class ConfigKeyAttribute : DescriptionAttribute
    {
        public Type ValueType { get; protected set; }
        public object DefaultValue { get; protected set; }
        public ConfigSection Section { get; private set; }
        public bool NotBlank { get; set; }
        public ConfigKey Key { get; internal set; }

        protected ConfigKeyAttribute(ConfigSection section, [NotNull] Type valueType, object defaultValue,
            [NotNull] string description) : base (description)
        {
            if (valueType == null) throw new ArgumentNullException("valueType");
            if (description == null) throw new ArgumentNullException("description");
            ValueType = valueType;
            DefaultValue = defaultValue;
            Section = section;
            NotBlank = false;
        }

        public bool TryValidate(string value)
        {
            try
            {
                Validate(value);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public virtual void Validate([NotNull] string value)
        {
            if (value == null) throw new ArgumentNullException("value");
            if (NotBlank && value.Length == 0)
            {
                throw new FormatException("Value cann't be blank or null");
            }
        }

        [DebuggerStepThrough]
        public virtual string Process(string value)
        {
            return value;
        }
    }

    internal sealed class StringKeyAttribute : ConfigKeyAttribute
    {
        public const int NoLengthRestriction = -1;
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public Regex Regex { get; set; }
        public bool RestrictedChars { get; set; }

        public StringKeyAttribute(ConfigSection section, object defaultValue, string description)
            : base(section, typeof(string), defaultValue, description)
        {
            MinLength = NoLengthRestriction;
            MaxLength = NoLengthRestriction;
            Regex = null;
        }
    }
}
