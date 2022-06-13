namespace WebApplication1.Models.Services
{
    public class Utility
    {
        public static User GenerateFakerData()
        {
            var user = new User
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                DateOfBirth = Faker.Identification.DateOfBirth(),
                Pan = "ADHYT1656O",
                Address = Faker.Address.StreetAddress(true),
                Gender = (char)Faker.Enum.Random<Gender>(),
                MobileNumber = Faker.Phone.Number(),
                Email = Faker.Internet.Email("rajnisir"),
                Comments = "Some test comment",
                DepartmentRefId = 1
            };
            return user;
        }
    }
}

enum Gender
{
    Male = 'M',
    Female = 'F',
    Other = 'O'
}