using System;
using System.Collections.Generic;
using System.Text;

namespace cs72console.Features
{
    // ・拡張メソッドの this 引数を参照にできる

    struct SA
    {
        public int PA;
        public int PB;
    }

    // 拡張メソッド
    static class SAExtensions
    {
        public static int GetPA(in this SA sa)
        {
            //return sa.PA = 11; ← sa は読み取り専用のためエラー
            return sa.PA;
        }
        public static int GetPB(ref this SA sa) => sa.PB = 22; // sa は参照なので値を変更できる
                                                               // public static int GetPB(in this SA sa) => sa.PB;  ← in と ref だけが異なる overload は定義できない
    }

    class RefExtensionMethodsOnStructs : IMain
    {
        public void Main()
        {
            var sa = new SA { PA = 10, PB = 20 };
            Console.WriteLine(sa.GetPA());  // 10 が出力される
            Console.WriteLine(sa.GetPB());  // 22 が出力される
            Console.WriteLine(sa.PB);       // 22 が出力される
        }
    }
}
