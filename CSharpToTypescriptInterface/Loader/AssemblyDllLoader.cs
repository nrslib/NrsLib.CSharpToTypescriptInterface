using System;
using System.Reflection;

namespace CSharpToTypescriptInterface.Loader {
    public class AssemblyDllLoader : IDllLoader{
        private readonly Assembly asm;

        public AssemblyDllLoader(Assembly asm)
        {
            this.asm = asm;
        }

        public Type[] GetTypes()
        {
            return asm.GetTypes();
        }
    }
}
