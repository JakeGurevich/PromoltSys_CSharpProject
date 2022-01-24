using Microsoft.AspNetCore.Mvc;
using Promolt.Core.Interfaces;
using Promolt.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {


        IDonationServices _donationServices;
        public DonationsController(IDonationServices DonationServices)
        {
            _donationServices = DonationServices;
        }

        // GET: api/<DonationsController>
        [HttpGet]
        public async Task<ActionResult<List<DonationModel>>>Get()
        {
            var donations = await _donationServices.GetDonations();
            return donations;
        }

        // GET api/<DonationsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DonationModel>> Get(string id)
        {
            var donation = await _donationServices.GetDonation(id);

            if (donation is null)
            {
                return NotFound();
            }

            return donation;
        }

        // POST api/<DonationsController>
        [HttpPost]
        public async Task<IActionResult> CreateDonation([FromBody] DonationModel newDonation)
        {
            await _donationServices.CreateDonation(newDonation);

            return CreatedAtAction(nameof(Get),new { id = newDonation.Id }, newDonation);


        }
        // PUT api/<DonationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
