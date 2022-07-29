using PoliticalParties.BusinessLayer.ViewModels;
using PoliticalParties.DataLayer;
using PoliticalParties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticalParties.BusinessLayer.Services.Repository
{
    public class PoliticalPartyRepository : IPoliticalPartyRepository
    {
        private readonly PoliticalPartiesDbContext _politicalPartiesDbContext;
        public PoliticalPartyRepository(PoliticalPartiesDbContext politicalPartiesDbContext)
        {
            _politicalPartiesDbContext = politicalPartiesDbContext;
        }

        public async Task<PoliticalParty> FindPoliticalPartyById(long politicalPartyId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PoliticalParty>> ListAllPoliticalParty()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<PoliticalParty> Register(PoliticalParty politicalParty)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<PoliticalParty> UpdatePoliticalParty(RegisterPoliticalPartyViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
