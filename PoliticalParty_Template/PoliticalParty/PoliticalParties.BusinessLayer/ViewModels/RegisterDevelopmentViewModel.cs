using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticalParties.BusinessLayer.ViewModels
{
    public class RegisterDevelopmentViewModel
    {
        public long DevelopmentId { get; set; }
        
        public string Title { get; set; }
        
        public string Activity { get; set; }
       
        public decimal Budget { get; set; }
       
        public long PoliticalLeaderId { get; set; }
       
        public int ActivityMonth { get; set; }
       
        public int ActivityYear { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}
