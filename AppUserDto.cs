using System.ComponentModel.DataAnnotations;

namespace IntegraMinimalApi
{
    public class AppUserDto
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Street is required.")]
        public string Street { get; set; } = string.Empty;

        [Required(ErrorMessage = "House number is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "House number must be greater than 0.")]
        public int HouseNumber { get; set; }

        public int? ApartmentNumber { get; set; }
    }
}
