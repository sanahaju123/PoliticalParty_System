using PoliticalParties.BusinessLayer.Interfaces;
using PoliticalParties.BusinessLayer.Services.Repository;
using PoliticalParties.BusinessLayer.ViewModels;
using PoliticalParties.DataLayer;
using PoliticalParties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticalParties.BusinessLayer.Services
{
    public class PoliticalPartyServices : IPoliticalPartyServices
    {
        private readonly IPoliticalPartyRepository _politicalPartyRepository;
        private readonly PoliticalPartiesDbContext _politicalPartiesDbContext;
        public PoliticalPartyServices(IPoliticalPartyRepository politicalPartyRepository,PoliticalPartiesDbContext politicalPartiesDbContext)
        {
            _politicalPartyRepository = politicalPartyRepository;
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
