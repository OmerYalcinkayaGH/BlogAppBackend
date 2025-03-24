using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Entities.Abstract;

namespace EntitiesLayer.Concrete
{
   public class User:IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime CeratedAt { get; set; }
     
    }
}
