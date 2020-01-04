using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData.Helper
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter, Inherited = true, AllowMultiple = false)]
    public class FromDIAttribute
        : Attribute
    {
    }
}
