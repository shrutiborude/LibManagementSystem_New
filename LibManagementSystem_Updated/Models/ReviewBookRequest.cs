using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibManagementSystem_Updated.Models
{
    public class ReviewBookRequest
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string BookName { get; set; }
        public string RequestStatus { get; set; }
    }
}
