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

        public void givenFirstName_WhenImProper_ShouldReturnFalse()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validateFirstName("P");
            Assert.False(isValid);

        }

        [Test]
        public void givenLastName_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validateLastName("Puneet");
            Assert.True(isValid);

        }

        public void givenLastName_WhenImProper_ShouldReturnFalse()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validateLastName("P");
            Assert.False(isValid);

        }

        [Test]
        public void givenEmail_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validateEmail("puneet@gmail.com");
            Assert.True(isValid);

        }

        public void givenEmail_WhenImProper_ShouldReturnFalse()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validateEmail("pun");
            Assert.False(isValid);

        }

        [Test]
        public void givenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validateMobileNumber("91 9899787676");
            Assert.True(isValid);

        }

        public void givenMobileNumber_WhenImProper_ShouldReturnFalse()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validateMobileNumber("91");
            Assert.False(isValid);

        }

        [Test]
        public void givenPassword_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validatePassword("adAwdse1d");
            Assert.True(isValid);

        }

        public void givenPassword_WhenProper_ShouldReturnFalse()
        {
            UserRegisteration user = new UserRegisteration();
            bool isValid = user.validatePassword("ads");
            Assert.False(isValid);

        }
    }
}