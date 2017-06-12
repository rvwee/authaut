using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RubenVanWee.TestData.Entities;

namespace RubenVanWee.TestApi
{
    [Route("api/[controller]")]
    public class IdentityController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AccountRegisterLogin model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors).Select(modelError => modelError.ErrorMessage).ToList());
            }

            var user = new UserEntity { UserName = model.Email, Email = model.Email };
            var result = await _
        }
    }

    public class AccountRegisterLogin
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}