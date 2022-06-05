using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ResumeDetailDto: IDto
    {
        //Burada işte resume bilgileri olacak
        //users tablosundaki telefon numarası felan çekilebilir ekstradan

        public int resume_id { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string adress { get; set; }
        public string skill { get; set; }
        public string language { get; set; }
    }
}
