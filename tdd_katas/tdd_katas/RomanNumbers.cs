namespace tdd_katas
{
    public class RomanNumbers
    {
        public string Convert(int number)
        {
            var result = RunningResult.From(number)
                .SimplifyWith(ArabicToRomanMapping.From(50, "L"))
                .SimplifyWith(ArabicToRomanMapping.From(10, "X"))
                .SimplifyWith(ArabicToRomanMapping.From(5, "V"))
                .AppendRemainder();
 
            return result.RomanNumber;
        }

        public class RunningResult
        {
            private int RemainderArabic { get; set; }
            public string RomanNumber { get; private set; }

            public static RunningResult From(int remainder) => new RunningResult
            {
                RemainderArabic = remainder,
                RomanNumber = string.Empty
            };

            private static RunningResult From(int remainder, string romanNumber) => new RunningResult
            {
                RemainderArabic = remainder,
                RomanNumber = romanNumber
            };
            
            public RunningResult SimplifyWith(ArabicToRomanMapping mapping)
            {
                var newArabic = RemainderArabic;
                var newRoman = RomanNumber;
            
                while (newArabic >= mapping.Arabic - 1)
                {
                    if (newArabic == mapping.Arabic - 1)
                        newRoman += "I";
                    newRoman += mapping.Roman;
                    newArabic -= mapping.Arabic;
                }

                return From(newArabic, newRoman);
            }

            public RunningResult AppendRemainder()
            {
                var newRoman = RomanNumber;
                for (var i = 0; i < RemainderArabic; i++) newRoman += "I";

                return From(RemainderArabic, newRoman);
            }
        }

        public class ArabicToRomanMapping
        {
            private ArabicToRomanMapping(int arabic, string roman)
            {
                Arabic = arabic;
                Roman = roman;
            }

            public static ArabicToRomanMapping From(int arabic, string roman) => new ArabicToRomanMapping(arabic, roman);

            public int Arabic { get; }
            public string Roman { get; }
        }
    }
}