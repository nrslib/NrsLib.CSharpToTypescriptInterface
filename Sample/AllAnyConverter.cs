using System;
using CSharpToTypescriptInterface.TypeAdjuster;
using CSharpToTypescriptInterface.TypeAdjuster.TypeConverter;

namespace Sample {
    class AllAnyConverter : ITypeConverter {
        public bool IsSatisfiedBy(Type source) {
            return true;
        }

        public string ConvertType(Type source, ITypeAdjuster adjuster) {
            return "any";
        }
    }
}
