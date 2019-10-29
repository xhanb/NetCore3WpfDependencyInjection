using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore3WpfDependencyInjection.Services
{
    public class SampleService : ISampleService
    {
        public async Task<string> GetCurrentDate() => await Task.FromResult(DateTime.Now.ToLongDateString());
    }
}
