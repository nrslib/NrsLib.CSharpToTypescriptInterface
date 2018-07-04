using System;
using CSharpToTypescriptInterface.TypeAdjuster.Spec;

namespace CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
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
