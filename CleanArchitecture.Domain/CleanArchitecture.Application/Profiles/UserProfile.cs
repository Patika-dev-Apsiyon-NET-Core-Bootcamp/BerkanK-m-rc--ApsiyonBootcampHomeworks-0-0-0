using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CleanArchitecture.Application.Profiles
{
    public class UserProfile :Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();
        }
    }
}
