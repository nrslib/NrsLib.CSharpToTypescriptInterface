using System;
using System.Collections.Generic;
using System.Linq;
using CSharpToTypescriptInterface.TypeAdjuster;

namespace NrsLib.CSharpToTypescriptInterface.TypeAdjuster.TypeConverter {
    public class ArrayTypeConverter : ITypeConverter {
        private static readonly Type[] AssignableTargets =
        {
            typeof(List<>),
            typeof(ICollection<>),
            typeof(IEnumerable<>),
            typeof(IReadOnlyCollection<>),
        };

        public string ConvertType(Type source, ITypeAdjuster adjuster)
        {
            if (source.IsArray)
            {
                return source.GetElementType() + "[]";
            }

            if (source.IsGenericType)
            {
                var genericTypeText = adjuster.ToTypescriptType(source.GenericTypeArguments.First());
                return genericTypeText + "[]";
            }

            return "[]";
        }

        public bool IsSatisfiedBy(Type source)
        {
            if (source.IsArray) {
                return true;
            }

            if (source.IsGenericType) {
                var genericTypeDefine = source.GetGenericTypeDefinition();

                bool IsAssignable(Type target) {
                    return target.IsAssignableFrom(genericTypeDefine);
                }

                return AssignableTargets.Any(IsAssignable);
            }

            return false;
        }
    }
}
