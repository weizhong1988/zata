﻿using System;
using Zata.FastReflection.Accessors.Factories;
using Zata.FastReflection.Accessors.Generics;
using Zata.FastReflection.Accessors.NonGenerics;

namespace Zata.FastReflection.Caching
{
    public interface IAccessorCache
    {
        IAccessorKeyStrategy KeyStrategy { get; set; }

        IAccessorFactory AccessorFactory { get; set; }

        void Regist(Type type);

        IPropertyAccessor FindPropertyAccessor(Type type, string propertyName);

        IGenericPropertyAccessor<T, P> FindPropertyAccessor<T, P>(string propertyName);
    }
}