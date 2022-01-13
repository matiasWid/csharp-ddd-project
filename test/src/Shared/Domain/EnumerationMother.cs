using System.Collections.Generic;
using System.Linq;
using CodelyTv.Shared.Domain.ValueObject;

namespace CodelyTv.Test.Shared.Domain
{
    public class EnumerationMother
    {
        public static Enumeration Random(IEnumerable<Enumeration> enumerations)
        {
            return MotherCreator.Random().Shuffle(enumerations).FirstOrDefault();
        }
    }
}
