using System;
using System.Collections.Generic;
using System.Text;

namespace cs72console.Features
{
    // ・三項演算子で参照(ref)を返せるようになった
    // ・参照が返るので、上記例の 3、4 つ目の様に結果に対して値を代入できる

    class ConditionalRefOperator : IMain
    {
        public void Main()
        {
            {
                var a = 10;
                var b = 20;
                ref var c = ref (true ? ref a : ref b);
                a = 11;
                b = 21;
                Console.WriteLine($"a:{a} b:{b} c:{c}");    // a: 11 b: 21 c: 11 と出力される
            }
            {
                var a = 10;
                var b = 20;
                ref var c = ref (false ? ref a : ref b);
                a = 12;
                b = 22;
                Console.WriteLine($"a:{a} b:{b} c:{c}");    // a: 12 b: 22 c: 22 と出力される
            }
            {
                var a = 10;
                var b = 20;
                (true ? ref a : ref b) = 13;
                Console.WriteLine($"a:{a} b:{b}");    // a: 13 b: 20 と出力される
            }
            {
                var a = 10;
                var b = 20;
                (false ? ref a : ref b) = 24;
                Console.WriteLine($"a:{a} b:{b}");    // a: 10 b: 24 と出力される
            }
        }
    }
}
