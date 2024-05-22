using System.Runtime.CompilerServices;

namespace IntegraMinimalApi
{
    public static class AppUserMapper
    {
        public static AppUser AppUserDtoToAppUser(this AppUserDto appUserDto)
        {
            return new AppUser
            {
                Name = appUserDto.Name,
                LastName = appUserDto.LastName,
                DateOfBirth = appUserDto.DateOfBirth,
                Country = appUserDto.Country,
                City = appUserDto.City,
                Street = appUserDto.Street,
                HouseNumber = appUserDto.HouseNumber,
                ApartmentNumber = appUserDto.ApartmentNumber
            };
        }
    }
}
