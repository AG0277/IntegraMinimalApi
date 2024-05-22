namespace IntegraMinimalApi
{
    public class AppUserDto
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int HouseNumber { get; set; }
        public int? ApartmentNumber { get; set; }
    }
}
