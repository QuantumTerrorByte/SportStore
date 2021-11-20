﻿using System.Collections.Generic;

namespace SportStore.Models.ViewModels
{
    public class UserEditRolesViewModel
    {
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public IList<string> UserRoles { get; set; } = new List<string>();
        public string[] AllRoles { get; set; } = System.Array.Empty<string>();
    }
}