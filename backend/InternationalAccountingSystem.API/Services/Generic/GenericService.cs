using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InternationalAccountingSystem.API.Repositories.Generic;

namespace InternationalAccountingSystem.API.Services.Generic
{
    public class GenericService<T, TDto> : IGenericService<T, TDto>
        where T : class
        where TDto : class
    {
        protected readonly IGenericRepository<T> _repository;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto?> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<TDto>(entity);
        }

        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
            return _mapper.Map<TDto>(entity);
        }

        public async Task<bool> UpdateAsync(long id, TDto dto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
            {
                return false;
            }
            _mapper.Map(dto, existing);
            await _repository.UpdateAsync(existing);
            await _repository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
            {
                return false;
            }
            await _repository.DeleteAsync(id);
            await _repository.SaveChangesAsync();
            return true;
        }
    }
}
