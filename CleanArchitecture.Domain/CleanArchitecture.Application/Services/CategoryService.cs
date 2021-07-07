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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository = null;
        private IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task<bool> Add(CategoryViewModel entity)
        {
            //_categoryRepository.Add(entity);
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            //_categoryRepository.Add(entity);
            throw new NotImplementedException();
        }

        public List<CategoryViewModel> GetAll()
        {
            return _mapper.Map<List<CategoryViewModel>>(_categoryRepository.GetAll());
        }

        public CategoryViewModel GetById(int id)
        {
            //_categoryRepository.GetById(id);
            throw new NotImplementedException();
        }

        public bool Update(CategoryViewModel entity)
        {
            //_categoryRepository.Update(entity);
            throw new NotImplementedException();
        }
    }
}
