using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData.Core
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
