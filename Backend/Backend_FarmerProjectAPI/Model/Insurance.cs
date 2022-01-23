using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_FarmerProjectAPI.Model
{
    public class Insurance
    {
        [Key]
        public int I_Id { get; set; }
        public string season { get; set; }
        public int year { get; set; }
        public string crop { get; set; }
        public int area { get; set; }
        public int sum_Insured { get; set; }
        public int share_Premium { get; set; }
        public int premium_Amount { get; set; }
        public int total_sum { get; set; }

        [ForeignKey("Insurance_Company")]
        public string Insurance_Company { get; set; }
        

    }
}
