namespace Template.Infrastructure.Extensions
{
    #region Usings
    using Serilog;
    using Microsoft.Extensions.Hosting;
    #endregion
    public static class HostCollectionExtensions
    {
        #region Methods
        public static IHostBuilder AddLogger(this IHostBuilder host, IConfiguration configuration)
        {
            host.UseSerilog((hostContext, services, _configuration) =>
            {
                _configuration.ReadFrom.Configuration(configuration);
            });
            return host;
        }
        #endregion
    }
}
