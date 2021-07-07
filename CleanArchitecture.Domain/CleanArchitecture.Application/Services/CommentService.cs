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
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository = null;
        private readonly IMapper _mapper;
        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }
        public Task<bool> Add(CommentViewModel entity)
        {
            //_commentRepository.Add(entity);
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            //_commentRepository.Delete(id);
            throw new NotImplementedException();
        }

        public List<CommentViewModel> GetAll()
        {
            //_commentRepository.GetAll();
            throw new NotImplementedException();
        }

        public CommentViewModel GetById(int id)
        {
            //_commentRepository.GetById(id);
            throw new NotImplementedException();
        }

        public bool Update(CommentViewModel entity)
        {
            //_commentRepository.Update(entity);
            throw new NotImplementedException();
        }
    }
}
