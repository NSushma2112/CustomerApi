using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cuntry { get; set; }
       
        public DateTime CreatedDate { get; set; }

    }
}
