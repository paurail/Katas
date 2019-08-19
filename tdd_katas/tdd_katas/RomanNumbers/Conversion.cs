namespace tdd_katas.RomanNumbers
{
    public class Conversion
    {
        private int RemainderArabic { get; set; }
        public string RomanNumber { get; private set; }

        public static Conversion From(int remainder) => new Conversion
        {
            RemainderArabic = remainder,
            RomanNumber = string.Empty
        };

        private static Conversion From(int remainder, string romanNumber) => new Conversion
        {
            RemainderArabic = remainder,
            RomanNumber = romanNumber
        };
            
        public Conversion SimplifyWith(ArabicToRomanPrimitive primitive)
        {
            var newArabic = RemainderArabic;
            var newRoman = RomanNumber;
            
            while (newArabic >= primitive.MinimumApplicableNumber)
            {
                if (newArabic < primitive.Arabic)
                {
                    newRoman += primitive.PreNumber.Roman;
                    newArabic -= primitive.MinimumApplicableNumber;
                }
                else newArabic -= primitive.Arabic;

                newRoman += primitive.Roman;
            }

            return From(newArabic, newRoman);
        }
    }
}