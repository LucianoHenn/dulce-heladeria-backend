using Dulce.Heladeria.Services.Dtos;
using Dulce.Heladeria.Services.IManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dulce.Heladeria.Repositories.IRepositories;
using AutoMapper;
using Dulce.Heladeria.Models.Entities;
using Dulce.Heladeria.Models.UnitOfWork;
using Dulce.Heladeria.Repositories.Repositories;

namespace Dulce.Heladeria.Services.Manager
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UserManager(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task<bool> InsertUser(CreateUserDto user)
        {
            var userEntity = _mapper.Map<UserEntity>(user);
            await _userRepository.InsertAsync(userEntity);
            var result = await _unitOfWork.SaveChangesAsync();
            return result == 1;  
        }
    }
}
