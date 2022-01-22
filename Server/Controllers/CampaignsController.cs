using Microsoft.AspNetCore.Mvc;
using Promolt.Core.Interfaces;
using Promolt.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController : ControllerBase
    {

        ICampaignServices _campaignServices;
        public CampaignsController(ICampaignServices CampaignServices)
        {
            _campaignServices = CampaignServices;
        }


        // GET: api/<CampaignsController>
        [HttpGet]
        public async Task<ActionResult<List<CampaignModel>>> Get()
        {
            var campaigns = await _campaignServices.GetCampaigns();
            return campaigns;
        }

        // GET api/<CampaignsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CampaignModel>> Get(string id)
        {
            var campaign = await _campaignServices.GetCampaign(id);

            if (campaign is null)
            {
                return NotFound();
            }

            return campaign;
        }

        // POST api/<CampaignsController>
        [HttpPost]
        public async Task<IActionResult> CreateCampaign(CampaignModel newCampaign)
        {
            await _campaignServices.CreateCampaign(newCampaign);

            return CreatedAtAction(nameof(Get), newCampaign);


        }

        // PUT api/<CampaignsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, CampaignModel updatedCampaign)
        {
            var campaign = await _campaignServices.GetCampaign(id);

            if (campaign is null)
            {
                return NotFound();
            }

            updatedCampaign.Id = campaign.Id;

            await _campaignServices.UpdateCampaign(id, updatedCampaign);

            return NoContent();
        }

        // DELETE api/<CampaignsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var campaign = await _campaignServices.GetCampaign(id);

            if (campaign is null)
            {
                return NotFound();
            }

            await _campaignServices.DeleteCampaign(id);

            return NoContent();
        }
    }
}
