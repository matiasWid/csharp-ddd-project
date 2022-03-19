using System;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Mooc.Students.Domain
{
    public class StudentName : StringValueObject
    {
        public StudentName(string value) : base(value)
        {
            EnsureMaxLengthNotRached(value);
        }

        private void EnsureMaxLengthNotRached(string value)
        {
            if(value.Length > 255)
            {
                throw new ArgumentException("");
            }
        }
    }
}
