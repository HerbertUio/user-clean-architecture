using Application.Test.Common;
using UserHub.Application.Services;
using UserHub.Domain.Models;

namespace Application.Test
{
    [TestClass]
    public class PersonServiceTest : TestBase
    {
        [TestMethod]
        public async Task CreateTest()
        {
            Guid id = Guid.NewGuid();
            string name = "Oscar";
            string lastname = "Quispe";
            string email = "herbert.buster@uab.edu.bo";
            string phoneNumber = "67998576";
            DateTime birthdate = new DateTime(1989, 01, 23);
            PersonModel personModel = new PersonModel(
                id,
                name,
                lastname,
                email,
                phoneNumber,
                birthdate

                );
            var personService = base.Resolve<PersonService>();
            var result = await personService.CreatePerson(personModel);

            Assert.IsNotNull(result);

        }
    }
}
