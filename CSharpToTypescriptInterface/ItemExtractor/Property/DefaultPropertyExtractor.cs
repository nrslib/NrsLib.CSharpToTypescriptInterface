using System;
using System.Reflection;

namespace CSharpToTypescriptInterface.ItemExtractor.Property {
    class DefaultPropertyExtractor : IPropertyExtractor {
        public bool IsSatisfiedBy(PropertyInfo propertyInfo)
        {
            var test = propertyInfo.GetMethod.IsPublic;
            if (!test)
            {
                Console.WriteLine();
            }

            return propertyInfo.GetMethod.IsPublic;
        }
    }
}
