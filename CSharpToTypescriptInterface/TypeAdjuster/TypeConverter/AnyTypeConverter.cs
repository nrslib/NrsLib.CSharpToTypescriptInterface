using System;

namespace CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
    public class AnyTypeConverter : ITypeConverter {
        public bool IsSatisfiedBy(Type source)
        {
            return source == typeof(Object) || source == typeof(object);
        }

        public string ConvertType(Type source, ITypeAdjuster adjuster)
        {
            return "any";
        }
    }
}
