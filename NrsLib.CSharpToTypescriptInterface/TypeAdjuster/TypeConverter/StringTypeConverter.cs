using System;
using NrsLib.CSharpToTypescriptInterface.TypeAdjuster.Spec;

namespace NrsLib.CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
    public class StringTypeConverter : ITypeConverter
    {
        private readonly StringSpec spec = new StringSpec();

        public bool IsSatisfiedBy(Type source)
        {
            return spec.IsSatisfiedBy(source);
        }

        public string ConvertType(Type source, ITypeAdjuster adjuster)
        {
            return "string";
        }
    }
}
