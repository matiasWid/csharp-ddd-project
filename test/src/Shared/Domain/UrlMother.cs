namespace CodelyTv.Test.Shared.Domain
{
    public class UrlMother
    {
        public static string Random()
        {
            return $"www.{MotherCreator.Random().String(minChar: 'a', maxChar: 'z')}.com";
        }
    }
}
