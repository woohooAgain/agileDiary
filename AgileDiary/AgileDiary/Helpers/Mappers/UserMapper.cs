using AgileDiary.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace AgileDiary.Helpers.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel Map(this IdentityUser user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Email = user.Email
            };
        }

        public static IdentityUser Map(this UserViewModel user)
        {
            return new IdentityUser
            {
                Id = user.Id,
                Email = user.Email
            };
        }
    }
}