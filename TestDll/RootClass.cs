using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDll
{
    public class RootClass
    {
        public int PublicField;
        protected int protectedField;
        private int privateField;

        public int PublicProperty { get; }
        protected int protectedProperty { get; }
        private int privateProperty { get; }

        public int? Nullable { get; }
        public object AnyType { get; }

        public int PublicMethod()
        {
            return 0;
        }

        protected int protectedMethod() {
            return 0;
        }

        private int privateMethod() {
            return 0;
        }
    }
}
