using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticalParties.BusinessLayer.ViewModels
{
    public class RegisterPoliticalLeaderViewModel
    {
        public long PoliticalLeaderId { get; set; }
       
        public string CandidateName { get; set; }
       
        public string StateName { get; set; }
      
        public long PoliticalPartyId { get; set; }
       
        public bool IsDeleted { get; set; }
    }
}
