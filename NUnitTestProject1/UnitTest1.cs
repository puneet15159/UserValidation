using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test]
        public void givenFirstName_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool check = user.validateFirstName("Puneet");
            Assert.True(check);

        }

        [Test]
        public void givenLastName_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool check = user.validateLastName("Puneet");
            Assert.True(check);

        }

        [Test]
        public void givenEmail_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool check = user.validateEmail("puneet@gmail.com");
            Assert.True(check);

        }

        [Test]
        public void givenMobileNumber_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool check = user.validateMobileNumber("91 9899787676");
            Assert.True(check);

        }

        [Test]
        public void givenPassword_WhenProper_ShouldReturnTrue()
        {
            UserRegisteration user = new UserRegisteration();
            bool check = user.validatePassword("adswdsed");
            Assert.True(check);

        }
    }
}