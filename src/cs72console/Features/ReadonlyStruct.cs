using System;
using System.Collections.Generic;
using System.Text;

namespace cs72console.Features
{
    // ・readonly struct は readonly なメンバーしか持てない
    // ・保持する値が変更されない(値が変更可能になる定義が禁止される)

    class ReadonlyStruct : IMain
    {
        readonly struct SA
        {
            public readonly int PA;
            // public int PB; ← これはエラー
            public SA(int a)
            {
                PA = a;
            }
            // public void Set(SA a) { this = a; } ← これはエラー
        }

        struct SB
        {
            public readonly int PA;
            public int PB; // ← readonly でなければ OK
            public SB(int a, int b)
            {
                PA = a;
                PB = b;
            }
            public void Set(SB a) { this = a; } // ← readonly でなければ OK
        }

        public void Main()
        {
            ;
        }
    }
}
