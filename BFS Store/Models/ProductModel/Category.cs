using System;
using System.Collections.Generic;

namespace SportStore.Models.ProductModel
{
    public class Category
    {
        public int Id { get; set; }
        public string ValueEn { get; set; }
        public string ValueRu { get; set; }
        public string ValueUk { get; set; }

        public bool Equals(Category other)
        {
            return ValueEn == other.ValueEn && ValueRu == other.ValueRu && ValueUk == other.ValueUk;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Category) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ValueEn, ValueRu, ValueUk);
        }

        public sealed class ValueEnEqualityComparer : IEqualityComparer<Category>
        {
            public bool Equals(Category x, Category y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.ValueEn == y.ValueEn;
            }

            public int GetHashCode(Category obj)
            {
                return (obj.ValueEn != null ? obj.ValueEn.GetHashCode() : 0);
            }
        }

        public static IEqualityComparer<Category> ValueEnComparer { get; } = new ValueEnEqualityComparer();
    }
}