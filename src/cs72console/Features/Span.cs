using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs72console.Features
{
    // ・Span は配列(など)の一部の範囲を切り出して値の参照を持てる
    // ・Sapn を new する際に引数で「2 番目の要素から長さ 3」と指定していますが、for で回した際に確かに「2 番目の要素から 3 つ」が出力された
    // ・最初に作った ary という配列の要素を変更した際に、Span の値も変更されているので確かに参照を持っている
    // ・Span だけでなく ReadOnlySpan という読み取り専用の型も存在する

    class Span : IMain
    {
        public void Main()
        {
            var ary = Enumerable.Range(1, 10).ToArray();
            var span = new Span<int>(ary, 2, 3);
            var readonlySpan = (ReadOnlySpan<int>)span;
            for (int i = 0; i < readonlySpan.Length; i++)
                Console.WriteLine(readonlySpan[i]);
            // 3
            // 4
            // 5 と出力される
            span[0] = 11;
            Console.WriteLine(readonlySpan[0]); // 11 と出力される
                                                // readonlySpan[0] = 21; ← これはエラー
            ary[2] = 31;
            Console.WriteLine(readonlySpan[0]); // 31 と出力される
        }
    }
}
