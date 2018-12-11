using System;
using SQLite;

namespace TestApp.Modal
{
    public class Post
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }



        [MaxLength(250)]
        public string Experience { get; set; }
    }
}
