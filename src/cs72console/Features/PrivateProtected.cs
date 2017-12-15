using System;
using System.Collections.Generic;
using System.Text;

namespace cs72console.Features
{
    // ・同一アセンブリ内でのみアクセスできる

    class PrivateProtected : PrivateProtectedLibrary.Class1, IMain
    {
        void MyMethod3()
        {
            // base.MyMethod(); ← これはエラー
        }

        public void Main()
        {
            ;
        }
    }
}
