﻿using System.Linq.Expressions;
using System.Reflection;

namespace ObjectPrinting
{
    public static class ExpressionExtensions
    {
        public static PropertyInfo GetProperty<T>(this Expression<T> expression)
        {
            return (expression.Body as MemberExpression)?.Member as PropertyInfo;
        }
    }
}
