using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string EmailAddress { get; set; }
        public string Age { get; set; }
        public string Rank { get; set; }

        public string FullName
        {
            get
            {
                return $"{ PersonName } { PersonSurname }";
            }
        }
    }
}
