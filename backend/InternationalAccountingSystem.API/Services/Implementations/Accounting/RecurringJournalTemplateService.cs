using AutoMapper;
using InternationalAccountingSystem.API.Entities.Accounting;
using InternationalAccountingSystem.API.Dtos.Accounting;
using InternationalAccountingSystem.API.Repositories.Interfaces.Accounting;
using InternationalAccountingSystem.API.Services.Generic;
using InternationalAccountingSystem.API.Services.Interfaces.Accounting;

namespace InternationalAccountingSystem.API.Services.Implementations.Accounting
{
    public class RecurringJournalTemplateService : GenericService<RecurringJournalTemplate, RecurringJournalTemplateDto>, IRecurringJournalTemplateService
    {
        public RecurringJournalTemplateService(IRecurringJournalTemplateRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
