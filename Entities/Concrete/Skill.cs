using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Skill: IEntity
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int resume_id { get; set; }
        public string skill { get; set; }
    }
}
