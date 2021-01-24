using Abp.Domain.Repositories;
using Abp.Localization;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Core.Currencies
{
    public class CurrencyManager : ICurrencyManager
    {
        public ILocalizationManager LocalizationManager { get; set; }
        private readonly IRepository<Currency, int> _repository;

        public CurrencyManager(
            IRepository<Currency, int> repository
        ){
            _repository = repository;
        }

        public async Task<Currency> CreateAsync(Currency currency)
        {
            await CheckDuplicateCurrency(currency);
            return await _repository.InsertAsync(currency);
        }

        public async Task<Currency> GetAsync(int id)
        {
            Currency currency = await _repository.GetAll().FirstOrDefaultAsync(r => r.Id == id);
            if(currency == null)
            {
                throw new UserFriendlyException(string.Format(L("CouldNotFoundMaybeDeleted"), L("Currency")));
            }
            return currency;
        }

        public async Task<Currency> UpdateAsync(Currency currency)
        {
            await CheckDuplicateCurrency(currency);
            return await _repository.UpdateAsync(currency);
        }

        public virtual async Task CheckDuplicateCurrency(Currency input)
        {
            Currency currency = (await _repository.FirstOrDefaultAsync(r => r.Symbol.Equals(input.Symbol, StringComparison.CurrentCultureIgnoreCase)));
            if(currency != null && input.Id != currency.Id)
            {
                throw new DuplicateWaitObjectException(string.Format(L("CurrencyDuplicate")));
            }
        }

        private string L(string name)
        {
            return LocalizationManager.GetString(FMSConsts.LocalizationSourceName, name);
        }
    }
}
