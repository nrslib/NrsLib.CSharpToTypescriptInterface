using System.Reflection;

namespace NrsLib.CSharpToTypescriptInterface.ItemExtractor.Property {
    class DefaultPropertyExtractor : IPropertyExtractor {
        public bool IsSatisfiedBy(PropertyInfo propertyInfo)
        {
            return propertyInfo.GetMethod.IsPublic;
        }
    }
}
