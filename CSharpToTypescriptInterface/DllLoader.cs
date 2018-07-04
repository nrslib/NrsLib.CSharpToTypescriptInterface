using System;
using System.IO;
using System.Reflection;

namespace CSharpToTypescriptInterface {
    public class DllLoader
    {
        private readonly string fullPath;

        public DllLoader(string fullPath)
        {
            if (string.IsNullOrEmpty(fullPath))
            {
                throw new ArgumentNullException(nameof(fullPath));
            }

            var extention = Path.GetExtension(fullPath);
            if (extention != ".dll")
            {
                throw new ArgumentException("extension is not dll", nameof(fullPath));
            }

            this.fullPath = fullPath;
        }

        public Type[] GetTypes()
        {
            var asm = Assembly.LoadFrom(fullPath);
            return asm.GetTypes();
        }
    }
}
