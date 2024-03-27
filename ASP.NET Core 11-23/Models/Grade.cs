﻿namespace ASP.NET_Core_11_23.Models {
    public class Grade {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public string Topic { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
    }

}
