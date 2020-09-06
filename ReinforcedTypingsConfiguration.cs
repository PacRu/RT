using System;
using System.Linq;
using System.Reflection;

using Reinforced.Typings.Fluent;

using Web.Models;

namespace Web
{
    public static class ReinforcedTypingsConfiguration
    {
        public static void Configure(ConfigurationBuilder builder)
        {
            var viewModelTypes = Assembly.GetExecutingAssembly().DefinedTypes
                .Where(v => string.Equals(typeof(ErrorViewModel).Namespace, v.Namespace, StringComparison.Ordinal))
                .Where(v => v.Name.EndsWith("ViewModel"))
                .ToArray();
            builder.ExportAsInterfaces(viewModelTypes, options =>
            {
                options.WithAllProperties();
            });
        }
    }
}