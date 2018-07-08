﻿using System;
using CSharpToTypescriptInterface.TypeSelectors;

namespace Sample {
    class MyExtractor : ITypeExtractor {
        public bool IsSatisfiedBy(Type t)
        {
            return t.Namespace?.StartsWith("ClassFileGenerator.Core.Meta") ?? false;
        }
    }
}