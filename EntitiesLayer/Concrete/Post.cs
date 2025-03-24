using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Entities.Abstract;
using static System.Net.Mime.MediaTypeNames;

namespace EntitiesLayer.Concrete
{
   public class Post:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
      
    }
}
