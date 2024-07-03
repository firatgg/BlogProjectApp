using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectApp.Entity.Entities
{
    public class Tag:BaseEntity
    {
        public string Content { get; set; }

        //navi

        public virtual List<Article> Articles { get; set; }
    }
}
