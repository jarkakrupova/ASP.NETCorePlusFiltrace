﻿using System.ComponentModel;

namespace ASP.NET_Core_11_23.DTO
{
    public class GradeDTO
    {
        public int Id { get; set; }
        [DisplayName("Student Name")]
        public int StudentId { get; set; }
        [DisplayName("Subject Name")]
        public int SubjectId { get; set; }
        public string Topic { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
    }
}
