using System;
using System.Collections.Generic;

namespace SportStore.Infrastructure
{
    public class Paginator
    {
        public static List<int> GetPagesModel(int totalItems, int pageSize, int currentPage)
        {
            var result = new List<int>();
            int totalPages = (int) Math.Ceiling((double) totalItems / pageSize);
            var from = 2;
            var limit = totalPages > 10 ? 10 : totalPages;

            if (totalPages > 10)
            {
                if (currentPage > 5 && currentPage < totalPages - 4)
                {
                    from = currentPage - 3;
                    limit = currentPage + 4;
                }
                else if (currentPage >= totalPages - 4)
                {
                    from = totalPages - 7;
                    limit = totalPages;
                }
            }

            result.Add(1);
            for (int i = from; i < limit; i++)
            {
                result.Add(i);
            }

            if (result.Count > 1)
            {
                result.Add(totalPages);
            }

            return result;
        }
    }
}