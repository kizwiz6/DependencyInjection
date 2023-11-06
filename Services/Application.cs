using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    /// <summary>
    /// Interface.
    /// </summary>
    public interface IApplication
    {
        void Run();
    }

    /// <summary>
    /// Application class.
    /// </summary>
    public class Application : IApplication
    {
        private readonly ILogger<Application> _logger;

        /// <summary>
        /// Constructor requires ILogger of Application
        /// The dependency injetion container created by the default host builder is already rigged to be able to provide this.
        /// </summary>
        public Application(ILogger<Application> logger)
                                        => _logger = logger;

        /// <summary>
        /// Run method
        /// </summary>
        public void Run()
        {
            _logger.LogInformation("Logging from the Application class!");
            Console.WriteLine("Hello, World from the Application class!");
        }
    }

}
