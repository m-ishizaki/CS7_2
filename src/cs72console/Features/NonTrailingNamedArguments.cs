using System;
using System.Collections.Generic;
using System.Text;

namespace cs72console.Features
{
    // ・位置が順番とあっていれば、末尾でなくても引数に名前を付けられる

    class NonTrailingNamedArguments : IMain
    {
        static void MyMethod(int a, int b, int c, int d)
        {
            ;
        }

        public void Main()
        {
            MyMethod(1, 2, c: 3, 4);           // ← c の位置が順番とあっているので OK
            MyMethod(1, 2, d: 3, c: 4);        // ← 名前付きが後方に集まっているので OK
                                               // MyMethod(1, c: 2, b: 3, 4);  // ← c、b の位置が順番とあっていないので NG
            MyMethod(d: 1, c: 2, b: 3, a: 4);  // ← 全て名前付きなので OK
                                               // MyMethod(1, c: 2, b: 3, a: 4); // ← a の位置は既に値が書かれている (1) ので NG
        }
    }
}
