using Xunit;

namespace OldPhoneKeypad.Tests
{
    public class PhoneKeypadTests
    {
        [Fact]
        public void OldPhonePad_33_Returns_E()
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad("33#");

            Assert.Equal("e", result);
        }

        [Fact]
        public void OldPhonePad_227Backspace_Returns_B()
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad("227*#");

            Assert.Equal("b", result);
        }

        [Fact]
        public void OldPhonePad_Hello_Returns_Hello()
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad("4433555 555666#");

            Assert.Equal("hello", result);
        }

        [Fact]
        public void OldPhonePad_Backspace_RemovesCharacter()
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad("2*#");

            Assert.Equal("", result);
        }

        [Fact]
        public void OldPhonePad_SpaceBetweenSameKey_ProducesCorrectText()
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad("22 222#");

            Assert.Equal("bc", result);
        }

        [Fact]
        public void OldPhonePad_Zero_ReturnsSpace()
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad("0#");

            Assert.Equal(" ", result);
        }

        [Fact]
        public void OldPhonePad_ComplexInput_ReturnsCorrectResult()
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad("8 88777444666*664#");

            Assert.Equal("turing", result);
        }

        [Theory]
        [InlineData("2#", "a")]
        [InlineData("22#", "b")]
        [InlineData("222#", "c")]
        [InlineData("2222#", "a")]
        public void OldPhonePad_TwoKey_CyclesCorrectly(string input, string expected)
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("7#", "p")]
        [InlineData("77#", "q")]
        [InlineData("777#", "r")]
        [InlineData("7777#", "s")]
        [InlineData("77777#", "p")]
        public void OldPhonePad_SevenKey_CyclesCorrectly(string input, string expected)
        {
            PhoneKeypad phoneKeypad = new PhoneKeypad();

            var result = phoneKeypad.OldPhonePad(input);

            Assert.Equal(expected, result);
        }

    }
}
