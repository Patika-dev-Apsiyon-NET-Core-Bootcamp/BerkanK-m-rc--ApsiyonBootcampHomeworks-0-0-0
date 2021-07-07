﻿using AutoMapper;
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
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository = null;
        private readonly IMapper _mapper;
        public TagService(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;

        }
        public Task<bool> Add(TagViewModel entity)

        {//_tagRepository.Add(entity);
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        { //_tagRepository.Delete(id);
            throw new NotImplementedException();
        }

        public List<TagViewModel> GetAll()
        {
            return _mapper.Map<List<TagViewModel>>(_tagRepository.GetAll());
        }

        public TagViewModel GetById(int id)
        {
            //_tagRepository.GetById(id);
            throw new NotImplementedException();
        }

        public bool Update(TagViewModel entity)
        {
            //_tagRepository.Update(entity);
            throw new NotImplementedException();
        }
    }
}
