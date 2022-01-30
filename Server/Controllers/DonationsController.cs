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
        ILogger<DonationsController> _logger;
        public DonationsController(IDonationServices DonationServices,ILogger<DonationsController> logger)
        {
            _donationServices = DonationServices;
            _logger = logger;
        }

        // GET: api/<DonationsController>
        [HttpGet]
        public async Task<ActionResult<List<DonationModel>>>Get()
        {
            _logger.LogInformation("Request working!");
            var donations = await _donationServices.GetDonations();
            return donations;
        }

        // GET: api/<DonationsController>
        [HttpGet("filter/{id}")]
        public async Task<ActionResult<List<DonationModel>>> GetDonations(string id)
        {
            var donations = await _donationServices.GetDonations(id);
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
        public async Task<IActionResult> Put(string id, [FromBody] DonationModel newDonation)
        {
            await _donationServices.UpdateDonation(id, newDonation);
            return Ok();
        }

        // DELETE api/<DonationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
