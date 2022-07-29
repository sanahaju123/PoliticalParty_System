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
    public class DevelopmentRepository : IDevelopmentRepository
    {
        private readonly PoliticalPartiesDbContext _politicalPartiesDbContext;
        public DevelopmentRepository(PoliticalPartiesDbContext politicalPartiesDbContext)
        {
            _politicalPartiesDbContext = politicalPartiesDbContext;
        }

        public async Task<IEnumerable<Development>> DevelopmentPlansByPoliticalLeaderId(long politicalLeaderId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Development> FindDevelopmentById(long developmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Development>> ListAllDevelopment()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Development> Register(Development development)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Development> UpdateDevelopment(RegisterDevelopmentViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}