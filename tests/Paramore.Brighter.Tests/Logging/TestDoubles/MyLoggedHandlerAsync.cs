using System.Threading;
using System.Threading.Tasks;
using Paramore.Brighter.Logging.Attributes;
using Paramore.Brighter.Tests.CommandProcessors.TestDoubles;

namespace Paramore.Brighter.Tests.Logging.TestDoubles
{
    internal class MyLoggedHandlerAsync : RequestHandlerAsync<MyCommand>
    {
        [RequestLoggingAsync(0, HandlerTiming.Before)]
        public override Task<MyCommand> HandleAsync(MyCommand command, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.HandleAsync(command, cancellationToken);
        }
    }
}
