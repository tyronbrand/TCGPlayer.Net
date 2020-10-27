using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;

namespace TCGPlayer.Net.Models
{
    public abstract class QueryStringParams : IQueryStringParams
    {
        public virtual string ToQueryString()
        {
            var props = this.GetType().GetProperties().Where(a => a.GetCustomAttributes<DisplayNameAttribute>().Any())
                .Select(
                    a => new
                    {
                        DisplayNameAttr = a.GetCustomAttributes<DisplayNameAttribute>().First(),
                        Prop = a
                    });

            var @params = props.Select(a =>
            {
                if (a.Prop.PropertyType == typeof(DateTime?))
                {
                    return $"{a.DisplayNameAttr.DisplayName}={((DateTime?)a.Prop.GetValue(this))?.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'")}";
                }

                if (a.Prop.PropertyType == typeof(bool?) || a.Prop.PropertyType == typeof(bool))
                {
                    return $"{a.DisplayNameAttr.DisplayName}={((bool?)a.Prop.GetValue(this))?.ToString().ToLowerInvariant()}";
                }

                if (a.Prop.PropertyType == typeof(string[]))
                {
                    return $"{a.DisplayNameAttr.DisplayName}={String.Join(",", (string[])a.Prop.GetValue(this))}";
                }

                if (a.Prop.PropertyType == typeof(int))
                    if ((int)a.Prop.GetValue(this) == 0)
                        return null;

                if (a.Prop.PropertyType == typeof(long))
                    if ((long)a.Prop.GetValue(this) == 0)
                        return null;

                if (a.Prop.PropertyType == typeof(string))
                    if (string.IsNullOrEmpty((string)a.Prop.GetValue(this)))
                        return null;

                return $"{a.DisplayNameAttr.DisplayName}={HttpUtility.UrlEncode(a.Prop.GetValue(this)?.ToString())}";
            });

            @params = @params.Where(w => !string.IsNullOrEmpty(w));

            return $"{string.Join("&", @params)}";
        }
    }
}
