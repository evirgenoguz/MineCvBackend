using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Resume: IEntity
    {
        public int id { get; set; }
        public int  user_id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string adress { get; set; }
    }
}
