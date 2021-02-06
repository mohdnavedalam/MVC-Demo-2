using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo_2.Models
{
    public class Video
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Category { get; set; }
        public string Format { get; set; }
    }
}