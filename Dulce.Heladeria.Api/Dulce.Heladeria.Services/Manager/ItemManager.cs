using AutoMapper;
using Dulce.Heladeria.DataAccess.Data;
using Dulce.Heladeria.Models.Entities;
using Dulce.Heladeria.Models.UnitOfWork;
using Dulce.Heladeria.Repositories.IRepositories;
using Dulce.Heladeria.Services.Dtos;
using Dulce.Heladeria.Services.IManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dulce.Heladeria.Services.Manager
{
    public class ItemManager : IItemManager
    {
        private readonly IItemRepository _itemRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ItemManager(IItemRepository itemRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }
        public async Task<bool> InsertItem(ItemDto item)
        {
            var itemEntity = _mapper.Map<ItemEntity>(item);

            await _itemRepository.InsertAsync(itemEntity);
            var resultsave = await _unitOfWork.SaveChangesAsync();
            
            return true;
        }
    }
}
