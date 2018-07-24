using System;
using System.Linq;
using CSharpToTypescriptInterface.TypeAdjuster;

namespace NrsLib.CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
    public class NullableTypeConverter : ITypeConverter {
        public bool IsSatisfiedBy(Type source)
        {
            return source.Name.StartsWith("Nullable");
        }

        public string ConvertType(Type source, ITypeAdjuster adjuster)
        {
            return adjuster.ToTypescriptType(source.GetGenericArguments().First());
        }
    }
}
