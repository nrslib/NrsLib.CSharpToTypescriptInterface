using System;
using CSharpToTypescriptInterface.TypeAdjuster.Spec;

namespace CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
    public class NumberTypeConverter : ITypeConverter
    {
        private readonly NumberSpec numSpec = new NumberSpec();

        public bool IsSatisfiedBy(Type source)
        {
            return numSpec.IsSatisfiedBy(source);
        }

        public string ConvertType(Type source, ITypeAdjuster adjuster)
        {
            return "number";
        }
    }
}
