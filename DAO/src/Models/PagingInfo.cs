using System;

namespace DAO.Models
{
    public class PagingInfo
    {
        public PagingInfo(int totalItems, int itemsPerPage, int currentPage)
        {
            TotalItems = totalItems;
            ItemsPerPage = itemsPerPage;
            CurrentPage = currentPage;
        }

        private int TotalItems { get; }
        private int ItemsPerPage { get; }
        public int CurrentPage { get; }

        public int TotalPages =>
            (int) Math.Ceiling((decimal) TotalItems / ItemsPerPage);
    }
}