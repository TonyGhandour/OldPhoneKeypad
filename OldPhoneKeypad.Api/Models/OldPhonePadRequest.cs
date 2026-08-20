using System.ComponentModel.DataAnnotations;

namespace OldPhoneKeypad.Api.Models
{
    public class OldPhonePadRequest
    {
        [Required]
        public string Input { get; set; } = string.Empty;
    }
}
