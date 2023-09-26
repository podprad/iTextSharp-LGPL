namespace iTextSharp.Tests
{
    using iTextSharp4.text.pdf;
    using NUnit.Framework;

    [TestFixture]
    public class MiscBugTests
    {
        [Test]
        public void Should_contain_font_resources()
        {
            var stream = BaseFont.GetResourceStream("iTextSharp4.iTextSharp.text.pdf.fonts.Helvetica.afm");
            Assert.IsNotNull(stream);
        }

        [Test]
        public void Should_load_font_resources()
        {
            Type1Font type1Font = new Type1Font("Helvetica", "Cp1252", false, null, null, false);
            Assert.IsNotNull(type1Font);
        }
    }
}