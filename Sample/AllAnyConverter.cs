using System;
using NrsLib.CSharpToTypescriptInterface.TypeAdjuster;
using NrsLib.CSharpToTypescriptInterface.TypeAdjuster.TypeConverter;

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
