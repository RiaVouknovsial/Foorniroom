using Foorniroom.Interfaces;

namespace Foorniroom.Services
{
    public class ValueService:IValueRepository
    {
       
            private readonly IValueRepository _valueRepository;

            public ValueService(IValueRepository valueRepository)
            {
                 _valueRepository = valueRepository;
            }

            public string GetValue()
            {
                return _valueRepository.GetValue();
            }
      
    }
}
