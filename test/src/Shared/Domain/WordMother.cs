namespace CodelyTv.Test.Shared.Domain
{
    public class WordMother
    {
        public static string Random()
        {
            return MotherCreator.Random().Word();
        }

        public static string Random(int MinimumLength)
        {
            string word = MotherCreator.Random().Word();
            while (word.Length < MinimumLength)
            {
                word = $"{word} {MotherCreator.Random().Word()}";
            }
            return word;
        }
    }
}
