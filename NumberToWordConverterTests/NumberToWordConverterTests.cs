using NumberToWordConverter;

namespace NumberToWordConverterTests
{
    public class NumberToWordConverterTests
    {
        [Fact]
        public void DecimalNumber_ExpectedText()
        {
            var converter = new NumberToWordConverter.Converter.NumberToWordConverter();
            double amount = 200.50;

            var txt = converter.Converter(amount);

            Assert.Equal("Two hundred pounds and fifty pence", txt);
        }

        [Fact]
        public void NegativeNumber_ErrorTextReturned()
        {
            var converter = new NumberToWordConverter.Converter.NumberToWordConverter();
            double amount = -1;

            var txt = converter.Converter(amount);

            Assert.Equal("number is out of range", txt);
        }

        [Fact]
        public void NoDecimalNumber_ExpectedText()
        {
            var converter = new NumberToWordConverter.Converter.NumberToWordConverter();
            double amount = 200;

            var txt = converter.Converter(amount);

            Assert.Equal("Two hundred pounds and zero pence", txt);
        }

        [Fact]
        public void TooBigNumber_ErrorTextReturned()
        {
            var converter = new NumberToWordConverter.Converter.NumberToWordConverter();
            double amount = 200000000000;

            var txt = converter.Converter(amount);

            Assert.Equal("number is out of range", txt);
        }
    }
}