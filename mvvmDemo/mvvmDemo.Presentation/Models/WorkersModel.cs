using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDemo.Presentation.Models
{
    public class WorkersModel
    {
        #region Constructor

        public WorkersModel(int id, string firstName, string lastName, string position, string
            phone)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
            this.Phone = phone;
        }

        #endregion Constructor

        #region DataProperties

        public int Id { get; set; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Position { set; get; }
        public string Phone { set; get; }

        #endregion DataProperties
    }
}
