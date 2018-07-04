using System;

namespace CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
    public class AsItIsTypeConverter : ITypeConverter {
        public bool IsSatisfiedBy(Type source)
        {
            return true;
        }

        public string ConvertType(Type source, ITypeAdjuster adjuster)
        {
            return source.Name;
        }
    }
}
