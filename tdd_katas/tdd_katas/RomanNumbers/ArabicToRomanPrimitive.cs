namespace tdd_katas.RomanNumbers
{
    public class ArabicToRomanPrimitive
    {
        protected ArabicToRomanPrimitive(int arabic, char roman, ArabicToRomanPrimitive preStep)
        {
            Arabic = arabic;
            Roman = roman;
            PreStep = preStep;
        }

        public static ArabicToRomanPrimitive From(int arabic, char roman, ArabicToRomanPrimitive preStep) => new ArabicToRomanPrimitive(arabic, roman, preStep);

        public int Arabic { get; }
        public char Roman { get; }
        public ArabicToRomanPrimitive PreStep { get; }

        public int MinimumApplicableNumber => Arabic - PreStep.Arabic;
    }
}