using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SampleData.Helper
{
    public class InjectAttribute
       : ActionFilterAttribute
    {
        private readonly BindingFlags _flags;
        private readonly InjectionUsages _usages;

        private void ProcessMembers(object value, InjectionUsages usages, BindingFlags flags, IServiceProvider provider)
        {
            var type = value.GetType();

            if (usages.HasFlag(InjectionUsages.Fields))
            {
                var fields = type.GetFields(flags)
                                 .Where(
                                    p => p.CustomAttributes.Any(
                                        attr => attr.AttributeType == typeof(FromDIAttribute)
                                    )
                                 );

                foreach (var field in fields)
                {
                    field.SetValue(value, provider.GetService(field.FieldType));
                }
            }
            if (usages.HasFlag(InjectionUsages.Properties))
            {
                var properties = type.GetProperties(flags)
                                               .Where(
                                                    p => p.CustomAttributes.Any(
                                                        attr => attr.AttributeType == typeof(FromDIAttribute)
                                                    )
                                                );

                foreach (var property in properties)
                {
                    property.SetValue(value, provider.GetService(property.PropertyType));
                }
            }
        }

        public InjectAttribute(
            BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
            InjectionUsages usages = InjectionUsages.Fields | InjectionUsages.Properties)
        {
            _flags = flags;
            _usages = usages;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var arguments = context.ActionArguments;
            var provider = context.HttpContext.RequestServices;
            foreach (var arg in arguments)
            {
                var value = arg.Value;
                ProcessMembers(value, _usages, _flags, provider);
            }
        }
    }
}
