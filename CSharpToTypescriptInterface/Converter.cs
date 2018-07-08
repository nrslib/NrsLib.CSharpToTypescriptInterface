using System;
using System.Linq;
using ClassFileGenerator;
using ClassFileGenerator.Core.Meta;
using ClassFileGenerator.Core.Templates;
using CSharpToTypescriptInterface.TypeAdjuster;
using CSharpToTypescriptInterface.TypeSelectors;

namespace CSharpToTypescriptInterface {
    public class Converter
    {
        private readonly DllLoader dllLoader;
        private ITypeAdjuster typeAdjuster = new DefaultTypeAdjuster();
        private ITypeExtractor extractor = new EveryExtractor();
        private readonly MainDriver classGenerateDriver = new MainDriver();

        public Converter(string dllFullPath)
        {
            dllLoader = new DllLoader(dllFullPath);
        }

        public ITypeAdjuster TypeAdjuster
        {
            get => typeAdjuster;
            set => typeAdjuster = value ?? throw new ArgumentNullException();
        }

        public ITypeExtractor TypeExtractor
        {
            get => extractor;
            set => extractor = value ?? throw new ArgumentNullException();
        }

        public T[] Convert<T>(Func<Type, string, T> predicate)
        {
            var types = dllLoader.GetTypes();
            var targets = types.Where(x => !x.Name.StartsWith("<>")).Where(x => extractor.IsSatisfiedBy(x));
            return targets
                .Select(ConvertTypeScript)
                .Select(tpl => predicate(tpl.Item1, tpl.Item2))
                .ToArray();
        }

        private (Type, string) ConvertTypeScript(Type type)
        {
            var meta = ToMeta(type);
            var content = classGenerateDriver.Create(meta, Language.Typescript);
            return (type, content);
        }

        private InterfaceMeta ToMeta(Type type)
        {
            var meta = new InterfaceMeta(type.Namespace, type.Name);
            var props = type.GetProperties();

            var fieldSetting = meta.SetupFields();

            foreach (var propertyInfo in props)
            {
                var fieldName = toLowerCase(propertyInfo.Name);
                var typeText = convertTypeName(propertyInfo.PropertyType);
                fieldSetting.AddField(fieldName, field => field.SetType(typeText));
            }

            var fields = type.GetFields().Where(x => x.IsPublic);
            foreach (var fieldInfo in fields) {
                var fieldName = toLowerCase(fieldInfo.Name);
                var typeText = convertTypeName(fieldInfo.FieldType);
                fieldSetting.AddField(fieldName, field => field.SetType(typeText));
            }

            var methods = type.GetMethods();
            var methodSetting = meta.SetupMethod();
            foreach (var methodInfo in methods)
            {
                var methodName = toLowerCase(methodInfo.Name);
                var typeText = convertTypeName(methodInfo.ReturnType);
                var parameters = methodInfo.GetParameters();
                methodSetting.AddMethod(methodName, method =>
                {
                    method.SetReturnType(typeText);
                    foreach (var param in parameters)
                    {
                        method.AddArgument(param.Name, convertTypeName(param.ParameterType));
                    }
                });
            }

            return meta;
        }

        private string toLowerCase(string arg)
        {
            if (string.IsNullOrEmpty(arg))
            {
                return "";
            }

            var head = arg.First().ToString().ToLower();
            return head + string.Join("", arg.Skip(1));
        }

        private string convertTypeName(Type type)
        {
            return typeAdjuster.ToTypescriptType(type);
        }
    }
}
