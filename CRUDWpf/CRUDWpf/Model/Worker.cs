using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWpf.Model
{
    public class Worker
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Position { set; get; }
        public string Phone { set; get; }

        public override string ToString()
        {
            return Id + ") " + FirstName + " " + LastName + ": " + Position + " Phone: " + Phone;
        }

    }
}
