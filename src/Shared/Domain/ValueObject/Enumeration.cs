using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodelyTv.Shared.Domain.ValueObject
{
    public abstract class Enumeration : ValueObject, IComparable
    {
        public string Value { get; private set; }

        public int Id { get; private set; }

        protected Enumeration(int id, string name) => (Id, Value) = (id, name);

        public override string ToString() => Value;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                     .Select(f => f.GetValue(null))
                     .Cast<T>();

        //public static Enumeration Get<T>(string value) =>
        //    (T)typeof(T).GetFields(BindingFlags.Public |
        //                        BindingFlags.Static |
        //                        BindingFlags.DeclaredOnly)
        //                .Select(f => f.GetValue(value));

        public override bool Equals(object obj)
        {
            if (obj is not Enumeration otherValue)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);

        //private static List<String> cache = new List<String>();
        //public string Value { get; }
        //protected Enumeration(string value)
        //{
        //    ensureIsBetweenAcceptedValues(value);
        //    Value = value;
        //}

        //private void ensureIsBetweenAcceptedValues(string value)
        //{
        //    if (cache.Count < 1)
        //        GetConstants();

        //    if (!cache.Contains(value))
        //        throw new InvalidEnumArgumentException(value);

        //}

        //public override string ToString()
        //{
        //    return Value;
        //}

        //protected override IEnumerable<object> GetAtomicValues()
        //{
        //    yield return Value;
        //}

        //public override bool Equals(object obj)
        //{
        //    if (this == obj) return true;

        //    var item = obj as StringValueObject;
        //    if (item == null) return false;

        //    return Value == item.Value;
        //}

        //private void GetConstants()
        //{
        //    foreach (var constant in this.GetType().GetFields())
        //    {
        //        if (constant.IsLiteral && !constant.IsInitOnly)
        //            cache.Add((string)constant.GetValue(this));

        //    }
        //}

        //public int CompareTo(object obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
