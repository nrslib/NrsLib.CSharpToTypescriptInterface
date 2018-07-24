using System;
using System.IO;
using System.Reflection;

namespace NrsLib.CSharpToTypescriptInterface.Loader {
    public class FileDllLoader : IDllLoader
    {
        private readonly string fullPath;

        public FileDllLoader(string fullPath)
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
