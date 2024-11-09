using Foorniroom.Interfaces;

namespace Foorniroom.Services
{
    public class NewService : INewService
    {
        private readonly IHelloRepository _helloRepository;

        public NewService(IHelloRepository helloRepository)
        {
            _helloRepository = helloRepository;
        }

        public string GetGreeting()
        {
            return _helloRepository.GetMessage();
        }
    }
}
