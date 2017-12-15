using System;
using System.Collections.Generic;
using System.Text;

namespace cs72console.Features
{
    // ・0x、0b の直後に _ を書けるようになった

    class AllowDigitSeparatorAfter0bOr0x : IMain
    {
        readonly int A = 0x1_2345;
        readonly int B = 0b1_0101;

        // C# 7.2 でないとエラー
        readonly int CS72A = 0x_1_2345;
        readonly int CS72B = 0b_1_0101;

        public void Main()
        {
            Console.WriteLine($"A    :{A}");
            Console.WriteLine($"B    :{B}");
            Console.WriteLine($"CS72A:{A}");
            Console.WriteLine($"CS72B:{CS72B}");
        }
    }
}
