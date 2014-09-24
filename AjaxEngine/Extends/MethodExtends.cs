﻿using AjaxEngine.Reflection;
using System.Collections.Generic;
using System.Reflection;

namespace AjaxEngine.Extends
{
    public static class MethodExtends
    {
        public static T GetAttribute<T>(this MethodInfo method)
        {
            return AttributeFactory.GetAttribute<T>(method);
        }
        public static List<T> GetAttributes<T>(this MethodInfo method)
        {
            return AttributeFactory.GetAttributes<T>(method);
        }
    }
}
