namespace WebApp.Services
{
    using System;
    using System.Collections.Generic;

    // Interface implementations created by Resharper
    public sealed class TestClass : IComparable<TestClass>, IComparable, IEquatable<TestClass>, IConvertible, IFormattable
    {
        private readonly long id = DateTime.UtcNow.Ticks;

        private IConvertible Id => id;

        public bool Equals(TestClass other)
        {
            if ( ReferenceEquals(null, other) ) return false;
            if ( ReferenceEquals(this, other) ) return true;
            return id == other.id;
        }

        public override bool Equals(object obj)
        {
            if ( ReferenceEquals(null, obj) ) return false;
            if ( ReferenceEquals(this, obj) ) return true;
            return obj is TestClass other && Equals(other);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override string ToString() => id.ToString();

        public string ToString(string format, IFormatProvider formatProvider) => id.ToString(format, formatProvider);

        public static bool operator ==(TestClass left, TestClass right) => Equals(left, right);

        public static bool operator !=(TestClass left, TestClass right) => !Equals(left, right);

        public int CompareTo(TestClass other)
        {
            if ( ReferenceEquals(this, other) ) return 0;
            if ( ReferenceEquals(null, other) ) return 1;
            return id.CompareTo(other.id);
        }

        public int CompareTo(object obj)
        {
            if ( ReferenceEquals(null, obj) ) return 1;
            if ( ReferenceEquals(this, obj) ) return 0;
            return obj is TestClass other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(TestClass)}");
        }

        public static bool operator <(TestClass left, TestClass right)
        {
            return Comparer<TestClass>.Default.Compare(left, right) < 0;
        }

        public static bool operator >(TestClass left, TestClass right)
        {
            return Comparer<TestClass>.Default.Compare(left, right) > 0;
        }

        public static bool operator <=(TestClass left, TestClass right)
        {
            return Comparer<TestClass>.Default.Compare(left, right) <= 0;
        }

        public static bool operator >=(TestClass left, TestClass right)
        {
            return Comparer<TestClass>.Default.Compare(left, right) >= 0;
        }

        public TypeCode GetTypeCode()
        {
            return Id.GetTypeCode();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return Id.ToBoolean(provider);
        }

        public byte ToByte(IFormatProvider provider)
        {
            return Id.ToByte(provider);
        }

        public char ToChar(IFormatProvider provider)
        {
            return Id.ToChar(provider);
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Id.ToDateTime(provider);
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return Id.ToDecimal(provider);
        }

        public double ToDouble(IFormatProvider provider)
        {
            return Id.ToDouble(provider);
        }

        public short ToInt16(IFormatProvider provider)
        {
            return Id.ToInt16(provider);
        }

        public int ToInt32(IFormatProvider provider)
        {
            return Id.ToInt32(provider);
        }

        public long ToInt64(IFormatProvider provider)
        {
            return Id.ToInt64(provider);
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            return Id.ToSByte(provider);
        }

        public float ToSingle(IFormatProvider provider)
        {
            return Id.ToSingle(provider);
        }

        public string ToString(IFormatProvider provider)
        {
            return Id.ToString(provider);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Id.ToType(conversionType, provider);
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return Id.ToUInt16(provider);
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return Id.ToUInt32(provider);
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return Id.ToUInt64(provider);
        }
    }
}
