using System;
using System.Collections.Generic;
using System.Text;

namespace SampleData.Entity
{
    public class PagedData<TEntity>
    {
        public IEnumerable<TEntity> Data { get; private set; }
        public int TotalDataCount { get; private set; }
        public int TotalDisplayableDataCount { get; private set; }

        public PagedData(IEnumerable<TEntity> data, int totalData, int totalDisplayableData)
        {
            Data = data;
            TotalDataCount = totalData;
            TotalDisplayableDataCount = totalDisplayableData;
        }
    }
}
