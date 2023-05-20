using AutoMapper;
using MySocialNetwork.Models;

namespace MySocialNetwork
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, RegisterViewModel>();
            CreateMap<User, LoginViewModel>();
        }
    }
}
