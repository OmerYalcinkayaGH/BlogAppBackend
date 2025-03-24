using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CoreLayer.Entities.Abstract;

namespace EntitiesLayer.Concrete
{
   public class Tag:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
