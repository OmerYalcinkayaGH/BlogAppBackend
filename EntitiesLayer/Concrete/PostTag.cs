using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Entities.Abstract;

namespace EntitiesLayer.Concrete
{
   public class PostTag:IEntity
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
       
    }
}
