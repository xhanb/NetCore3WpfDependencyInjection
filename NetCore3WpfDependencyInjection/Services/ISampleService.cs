using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore3WpfDependencyInjection.Services
{
    public interface ISampleService
    {
        Task<string> GetCurrentDate();
    }
}
