using System;

namespace PrivateProtectedLibrary
{
    // ・同一アセンブリ内でのみアクセスできる

    public class Class1
    {
        private protected void MyMethod() {; }
    }

    public class Class3 : Class1
    {
        void MyMethod2() { base.MyMethod(); } // ← 同一アセンブリ内の派生クラスは OK
    }
}
