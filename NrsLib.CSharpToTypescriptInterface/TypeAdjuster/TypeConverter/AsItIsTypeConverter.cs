using System;
using CSharpToTypescriptInterface.TypeAdjuster;

namespace NrsLib.CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
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
