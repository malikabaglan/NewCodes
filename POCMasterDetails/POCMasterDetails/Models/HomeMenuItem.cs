using System;
using System.Collections.Generic;
using System.Text;

namespace POCMasterDetails.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        TermsAndConditions
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

    }
}
