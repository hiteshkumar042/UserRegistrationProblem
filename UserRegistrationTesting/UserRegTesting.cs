using UserRegistrationProblem;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UserRegTesting
    {
        //Happy Test Cases(Test Cases Pass The Entries)
        [TestMethod]
        [DataRow("Hitesh")]
        [DataRow("Kumar")]
        [DataRow("Solanki")]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue(string firstName)
        {
            //Arrange
            RegistrationValidate registrationValidate = new RegistrationValidate();
            //Act
            bool result = registrationValidate.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("Kumar")]
        [DataRow("Gupta")]
        [DataRow("Sharma")]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue(string lastName)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("hiteshkumar794@gmail.com")]
        [DataRow("hiteshkumar794.solanki@gmail.com")]
        [DataRow("hitesh794@gmail.com")]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue(string email)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("918875208042")]
        [DataRow("919321112345")]
        [DataRow("918875208042")]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue(string mobNumber)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateMobileNumber(mobNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("Hitesh@123")]
        [DataRow("Pass@123")]
        [DataRow("Password@123")]
        public void GivenPassword_WhenValidate_ShouldReturnTrue(string password)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //(Test Cases Fail The Entry)
        [TestMethod]
        [DataRow("hk")]
        [DataRow("Rame$h")]
        [DataRow("@ramesh")]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse(string firstName)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("pk")]
        [DataRow("$uthar")]
        [DataRow("anjhan@")]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse(string lastName)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("pk@gm")]
        [DataRow("hitesh@.com")]
        [DataRow("sol@gmail")]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse(string email)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("8875208042")]
        [DataRow("93211 12345")]
        [DataRow("875208042")]

        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse(string mobNumber)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidateMobileNumber(mobNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("Hite123")]
        [DataRow("Pa12")]
        [DataRow("asswr")]
        public void GivenPassword_WhenValidate_ShouldReturnFalse(string password)
        {
            //Arrange
            RegistrationValidate user = new RegistrationValidate();
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);

        }
    }
}