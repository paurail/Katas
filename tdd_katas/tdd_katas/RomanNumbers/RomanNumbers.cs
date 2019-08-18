using System.Collections.Generic;
using System.Linq;

namespace tdd_katas.RomanNumbers
{
    public class RomanNumbers
    {
        static ArabicToRomanPrimitive One => ArabicToRomanPrimitive.From(1, 'I', new EmptyPrimitive());
        static ArabicToRomanPrimitive Five = ArabicToRomanPrimitive.From(5, 'V', One);
        static ArabicToRomanPrimitive Ten = ArabicToRomanPrimitive.From(10, 'X', One);
        static ArabicToRomanPrimitive Fifty = ArabicToRomanPrimitive.From(50, 'L', Ten);
        static ArabicToRomanPrimitive Hundred = ArabicToRomanPrimitive.From(100, 'C', Ten);
        static ArabicToRomanPrimitive FiveHunderd = ArabicToRomanPrimitive.From(500, 'D', Hundred);
        static ArabicToRomanPrimitive Thausand = ArabicToRomanPrimitive.From(1000, 'M', Hundred);

        private List<ArabicToRomanPrimitive> _numberMappings = new List<ArabicToRomanPrimitive>
        {
            Thausand, FiveHunderd, Hundred, Fifty, Ten, Five, One
        };
        public string Convert(int number)
        {
            var result = Conversion.From(number);
            result = _numberMappings.Aggregate(result, (current, c) => current.SimplifyWith(c));

            return result.RomanNumber;
        }
    }
}