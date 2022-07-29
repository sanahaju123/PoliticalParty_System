﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoliticalParties.BusinessLayer.Interfaces;
using PoliticalParties.BusinessLayer.ViewModels;
using PoliticalParties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliticalParties.Controllers
{
    [ApiController]
    public class DevelopmentController : ControllerBase
    {
        private readonly IDevelopmentServices _developmentServices;

        public DevelopmentController(IDevelopmentServices developmentServices)
        {
            _developmentServices = developmentServices;
        }

        #region DevelopmentRegion
        /// <summary>
        /// Register a new Development
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("developments")]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromBody] RegisterDevelopmentViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a existing Development
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("developments")]
        public async Task<IActionResult> UpdateDevelopment([FromBody] RegisterDevelopmentViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a existing Development
        /// </summary>
        /// <param name="developmentId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("developments/{developmentId}")]
        public async Task<IActionResult> DeleteDevelopment(long developmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Development by Id
        /// </summary>
        /// <param name="developmentId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("developments/{developmentId}")]
        public async Task<IActionResult> GetDevelopmentById(long developmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// List All Developments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("developments")]
        public async Task<IEnumerable<Development>> ListAllDevelopments()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetches all the development plans created for a political leader
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("leaders/by-leader-id/{politicalLeaderId}")]
        public async Task<IEnumerable<Development>> DevelopmentPlansByPoliticalLeaderId(long politicalLeaderId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        #endregion

    }
}
