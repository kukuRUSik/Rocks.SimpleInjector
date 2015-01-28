﻿using System;
using System.Reflection;
using JetBrains.Annotations;

namespace Rocks.SimpleInjector.Attributes
{
    /// <summary>
    ///     Marks member as not mutable making it safe to be used as part of the singleton dependency.
    /// </summary>
    [AttributeUsage (AttributeTargets.All, Inherited = false)]
    public sealed class NotMutableAttribute : Attribute
    {
        public static bool ExsitsOn ([NotNull] Type type)
        {
            var attr = type.GetCustomAttribute (typeof (NotMutableAttribute), false);
            return attr != null;
        }


        public static bool ExsitsOn ([NotNull] MemberInfo member)
        {
            var attr = member.GetCustomAttribute (typeof (NotMutableAttribute), false);
            return attr != null;
        }
    }
}