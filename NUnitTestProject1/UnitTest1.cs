using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test]
        public void givenFirstName_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validateFirstName("Puneet");
            Assert.True(isValid);

        }

    }
}