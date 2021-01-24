using Microsoft.Extensions.Configuration;

namespace FMS.Core.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
