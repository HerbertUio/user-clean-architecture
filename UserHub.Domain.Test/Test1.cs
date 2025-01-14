using UserHub.Domain.Exceptions;
using UserHub.Domain.Models;

namespace UserHub.Domain.Test
{
    [TestClass]
    public class PersonModelTest
    {
        [TestMethod]
        public void ValidCreatePersonModel()
        {
            Guid id = Guid.NewGuid();
            string name = "Oscar";
            string lastname = "Quispe";
            string email = "oscar.quispe@gmail.com";
            string phoneNumber = "67998576";
            DateTime birthdate = new DateTime(1989, 01, 23);

            PersonModel result = new PersonModel(id, name, lastname, email, phoneNumber, birthdate);

            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidEmailException))]
        [DataRow("oscar.quispe@gmail")]
        [DataRow("oscar.quispegmail.com")]
        [DataRow("oscar_quispegmailcom")]

        public void ValidateEmailExceptionTest(string email)
        {
            Guid id = Guid.NewGuid();
            string name = "Oscar";
            string lastname = "Quispe";
            string phoneNumber = "67998576";
            DateTime birthdate = new DateTime(1989, 01, 23);

            PersonModel result = new PersonModel(id, name, lastname, email, phoneNumber, birthdate);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPhoneNumberException))]
        [DataRow("67998576/")]
        [DataRow("+67998576/")]
        [DataRow("+ 5916799857.6")]
        [DataRow("+ 591 679{98576")]
        [DataRow("+ 591 6799 e# 857667998576")]

        public void ValidPhoneNumberExceptionTest(string phoneNumber)
        {
            Guid id = Guid.NewGuid();
            string name = "Oscar";
            string lastname = "Quispe";
            string email = "oscar.quispe@gmail.com";
            DateTime birthdate = new DateTime(1989, 01, 23);

            PersonModel result = new PersonModel(id, name, lastname, email, phoneNumber, birthdate);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBirthdateException))]

        public void ValidBirthdateExceptionTest()
        {
            Guid id = Guid.NewGuid();
            string name = "Oscar";
            string lastname = "Quispe";
            string email = "oscar.quispe@gmail.com";
            string phoneNumber = "67998576";
            DateTime birthdate = new DateTime(2012, 01, 1);

            PersonModel result = new PersonModel(id, name, lastname, email, phoneNumber, birthdate);
        }
    }
}
