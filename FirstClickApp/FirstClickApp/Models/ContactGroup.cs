﻿using System;
using System.Collections.Generic;

namespace FirstClickApp.Models
{
    public class ContactGroup : List<Contact>
    {

        public string Title { get; set; }
        public string ShortTitle { get; set; }


        public ContactGroup(string title,string shortTitle)
        {

            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
