﻿using PoliticalParties.BusinessLayer.Interfaces;
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
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PoliticalLeader>> ListAllPoliticalLeader()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PoliticalLeader>> PoliticalLeadersByPoliticalPartyId(long politicalPartyId)
        {
            throw new NotImplementedException();
        }

        public async Task<PoliticalLeader> Register(PoliticalLeader politicalLeader)
        {
            throw new NotImplementedException();
        }

        public async Task<PoliticalLeader> UpdatePoliticalLeader(RegisterPoliticalLeaderViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
