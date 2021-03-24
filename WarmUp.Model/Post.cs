using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUp.Model
{
    public class Post : Entity
    {
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Content")]
        public string Content { get; set; }
        [DisplayName("Image")]
        public byte[] Image { get; set; }
        [DisplayName("Category")]
        public string Category { get; set; }
        [DisplayName("Create date")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Active")]
        public bool Active { get; set; }
    }
}
