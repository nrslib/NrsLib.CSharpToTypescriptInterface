using System;
using System.Collections.Generic;
using System.Linq;
using CSharpToTypescriptInterface.TypeAdjuster.TypeConverter;

namespace CSharpToTypescriptInterface.TypeAdjuster {
    public class DefaultTypeAdjuster : ITypeAdjuster {
        private readonly Dictionary<Type, ITypeConverter> cache = new Dictionary<Type, ITypeConverter>();

        private readonly List<ITypeConverter> converters = new List<ITypeConverter>
        {
            new StringTypeConverter(),
            new NumberTypeConverter(),
            new ArrayTypeConverter(),
            new AsItIsTypeConverter(),
        };

        public string ToTypescriptType(Type type)
        {
            if (!cache.TryGetValue(type, out var converter))
            {
                converter = converters.First(x => x.IsSatisfiedBy(type));
                cache[type] = converter;
            }

            return converter.ConvertType(type, this);
        }

        public void AddConverter(ITypeConverter converter)
        {
            this.converters.Insert(0, converter);
        }
    }
}
