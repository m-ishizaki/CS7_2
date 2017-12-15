using System;
using System.Collections.Generic;
using System.Text;

namespace cs72console.Features
{
    // ・構造体を参照で渡してパフォーマンスを上げたいが、メソッド内/ return 先で書き換えられたくない場合に使う
    // ・構造体を参照で渡しつつ、読み取り専用に制限できる

    class InParametersRefReadonlyReturns : IMain
    {
        struct SB
        {
            public int PA;
            public void Set(int a) => this.PA = a;
        }

        static ref readonly SB MyMethod(in SB a)
        {
            // a.PA = 11; ← 読み取り専用になるため値を変更できない
            // a = new SB(); ←読み取り専用になるため値を変更できない
            Console.WriteLine(a.PA); // 10 と出力される
            a.Set(12);               // ←エラーにはならないが、読み取り専用になるため値を変更できない
            Console.WriteLine(a.PA); // 10 と出力される
            return ref a;
        }

        public void Main()
        {
            var sb1 = new SB { PA = 10 };
            ref readonly var sb2 = ref MyMethod(sb1);
            Console.WriteLine(sb1.PA); // 10 と出力される
            Console.WriteLine(sb2.PA); // 10 と出力される
            sb1.Set(13);
            Console.WriteLine(sb1.PA); // 13 と出力される
            Console.WriteLine(sb2.PA); // 13 と出力される
                                       // sb2.PA = 14; //  ←読み取り専用になるため値を変更できない
            sb2.Set(14);    //  ←エラーにはならないが、読み取り専用になるため値を変更できない
            Console.WriteLine(sb1.PA); // 13 と出力される
            Console.WriteLine(sb2.PA); // 13 と出力される
        }
    }
}
