namespace tdd_katas.RomanNumbers
{
    public class ArabicToRomanPrimitive
    {
        protected ArabicToRomanPrimitive(int arabic, char roman, ArabicToRomanPrimitive preNumber)
        {
            Arabic = arabic;
            Roman = roman;
            PreNumber = preNumber;
        }

        public static ArabicToRomanPrimitive From(int arabic, char roman, ArabicToRomanPrimitive preNumber) => new ArabicToRomanPrimitive(arabic, roman, preNumber);

        public int Arabic { get; }
        public char Roman { get; }
        public ArabicToRomanPrimitive PreNumber { get; }

        public int MinimumApplicableNumber => Arabic - PreNumber.Arabic;
    }
}