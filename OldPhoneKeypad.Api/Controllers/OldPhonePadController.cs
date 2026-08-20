using Microsoft.AspNetCore.Mvc;
using OldPhoneKeypad.Api.Models;

namespace OldPhoneKeypad.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OldPhonePadController : ControllerBase
    {
        private readonly PhoneKeypad _phoneKeypad;
        public OldPhonePadController(PhoneKeypad phoneKeypad)
        {
            _phoneKeypad = phoneKeypad;
        }

        [HttpPost]
        public ActionResult<OldPhonePadResponse> Convert(
            [FromBody] OldPhonePadRequest request)
        {
            var result = _phoneKeypad.OldPhonePad(request.Input);

            return Ok(new OldPhonePadResponse
            {
                Output = result
            });
        }
    }
}
