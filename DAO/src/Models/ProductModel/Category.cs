using System;

namespace DAO.Models.ProductModel
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

    }
}