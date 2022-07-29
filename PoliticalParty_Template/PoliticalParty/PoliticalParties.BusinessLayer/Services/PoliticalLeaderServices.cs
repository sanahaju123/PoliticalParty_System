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
    public class PoliticalLeaderServices : IPoliticalLeaderServices
    {
        private readonly IPoliticalLeaderRepository _politicalLeaderRepository;
        private readonly PoliticalPartiesDbContext _politicalPartiesDbContext;
        public PoliticalLeaderServices(IPoliticalLeaderRepository politicalLeaderRepository, PoliticalPartiesDbContext politicalPartiesDbContext)
        {
            _politicalLeaderRepository = politicalLeaderRepository;
            _politicalPartiesDbContext = politicalPartiesDbContext;
        }

        public async Task<PoliticalLeader> FindPoliticalLeaderById(long politicalLeaderId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PoliticalLeader>> ListAllPoliticalLeader()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PoliticalLeader>> PoliticalLeadersByPoliticalPartyId(long politicalPartyId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<PoliticalLeader> Register(PoliticalLeader politicalLeader)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<PoliticalLeader> UpdatePoliticalLeader(RegisterPoliticalLeaderViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
