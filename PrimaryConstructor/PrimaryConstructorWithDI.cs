using Microsoft.Extensions.Logging;

namespace Net8Features.PrimaryConstructor
{
    // without primary constructor example for the DI without base class
    public class WithoutPrimaryConstructorDIWithOutBaseClass
    {
        private readonly ILogger<WithoutPrimaryConstructorDIWithOutBaseClass> logger;

        public WithoutPrimaryConstructorDIWithOutBaseClass(ILogger<WithoutPrimaryConstructorDIWithOutBaseClass> logger)
        {
            logger = logger;
        }

        public void GetLogDetails() => Console.WriteLine($"Type: {logger.GetType()}");
    }

    // primary constructor example for the DI without base class
    public class PrimaryConstructorWithDI(ILogger<PrimaryConstructorWithDI> logger)
    {
        private readonly ILogger<PrimaryConstructorWithDI> logger = logger;

        public void GetLogDetails() => Console.WriteLine($"Type: {logger.GetType()}");
    }

    // Base class
    public class BaseClass(ILogger<BaseClass> logger)
    {
        private readonly ILogger<BaseClass> logger = logger;
    }

    // without primary constructor example for the DI with base class
    public class WithoutPrimaryConstructorDIWithBaseClass : BaseClass
    {
        private readonly ILogger<WithoutPrimaryConstructorDIWithBaseClass> logger;
        public WithoutPrimaryConstructorDIWithBaseClass(ILogger<WithoutPrimaryConstructorDIWithBaseClass> logger) : base(logger)
        {
            logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void GetLogDetails() => Console.WriteLine($"Type: {logger.GetType()}");
    }

    // Primary constructor example for the DI with base class
    public class PrimaryConstructorDIWithBaseClass(ILogger<PrimaryConstructorDIWithBaseClass> logger) : BaseClass(logger)
    {
        private readonly ILogger<PrimaryConstructorDIWithBaseClass> logger = logger ?? throw new ArgumentNullException(nameof(logger));

        public void GetLogDetails() => Console.WriteLine($"Type: {logger.GetType()}");
    }
    
}
