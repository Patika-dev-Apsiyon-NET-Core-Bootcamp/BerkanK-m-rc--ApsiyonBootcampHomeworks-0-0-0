using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentViewModel, Comment>();
            CreateMap<Comment, CommentViewModel>();
        }
    }
}
