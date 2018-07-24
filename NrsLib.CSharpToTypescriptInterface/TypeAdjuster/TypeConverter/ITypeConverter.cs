using System;

namespace NrsLib.CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
    public interface ITypeConverter
    {
        bool IsSatisfiedBy(Type source);
        string ConvertType(Type source, ITypeAdjuster adjuster);
    }
}
