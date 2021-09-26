using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SportStoreTests.Infrastructure
{
    public class QueryableList<T>: List<T> ,IQueryable<T>
    {
        public Type ElementType { get; }
        public Expression Expression { get; }
        public IQueryProvider Provider { get; }
    }
}