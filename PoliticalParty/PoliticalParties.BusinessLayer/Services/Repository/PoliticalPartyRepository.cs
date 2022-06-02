﻿using PoliticalParties.BusinessLayer.ViewModels;
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
            try
            {
                return await _politicalPartiesDbContext.PoliticalParties.FindAsync(politicalPartyId);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<IEnumerable<PoliticalParty>> ListAllPoliticalParty()
        {
            try
            {
                var result = _politicalPartiesDbContext.PoliticalParties.
                OrderByDescending(x => x.PoliticalPartyId).Take(10).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<PoliticalParty> Register(PoliticalParty politicalParty)
        {
            try
            {
                var result = await _politicalPartiesDbContext.PoliticalParties.AddAsync(politicalParty);
                await _politicalPartiesDbContext.SaveChangesAsync();
                return politicalParty;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<PoliticalParty> UpdatePoliticalParty(RegisterPoliticalPartyViewModel model)
        {
            var politicalParty = await _politicalPartiesDbContext.PoliticalParties.FindAsync(model.PoliticalPartyId);
            try
            {

                politicalParty.Name = model.Name;
                politicalParty.Founder = model.Founder;
                politicalParty.IsDeleted = model.IsDeleted;


                _politicalPartiesDbContext.PoliticalParties.Update(politicalParty);
                await _politicalPartiesDbContext.SaveChangesAsync();
                return politicalParty;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
