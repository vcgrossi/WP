using System;
namespace WpBlog.model
{
    public class comments{
        public int id { get; set; }
        public user user{ get; set; }
        public DateTime createDate{ get; set; }
        public string content{ get; set; }
    }
}