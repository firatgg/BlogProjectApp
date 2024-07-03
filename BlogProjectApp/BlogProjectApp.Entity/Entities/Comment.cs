using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Entity.Entities
{
    public class Comment:BaseEntity
    {
        public string Content { get; set; }
        public int UserId { get; set; }
        public int ArticleId { get; set; }

        //navi

        public virtual Article Article { get; set; }
    }
}
