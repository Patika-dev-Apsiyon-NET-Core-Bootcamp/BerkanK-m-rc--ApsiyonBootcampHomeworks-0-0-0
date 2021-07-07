using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository = null;
        private IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public Task<bool> Add(UserViewModel entity)
        {
            //_userRepository.Add(entity);
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {

            //_userRepository.Delete(id);
            throw new NotImplementedException();
        }

        public List<UserViewModel> GetAll()
        {
            //_userRepository.GetAll();
            throw new NotImplementedException();
        }

        public UserViewModel GetById(int id)
        {//_userRepository.GetById(id);
            throw new NotImplementedException();
        }

        public bool Update(UserViewModel entity)
        {//_userRepository.Update(entity);
            throw new NotImplementedException();
        }
    }
}
