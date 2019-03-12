using System;
namespace UpdatedArabianDall.Helpers
{
    public class PageAttribute : Attribute
    {
        public string Name { get; set; }

        public PageAttribute()
        {

        }

        public PageAttribute(string name)
        {
            Name = name;
        }
    }
}