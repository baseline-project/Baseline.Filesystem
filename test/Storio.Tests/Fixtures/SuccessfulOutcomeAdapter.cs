using System.Threading;
using System.Threading.Tasks;

namespace Storio.Tests.Fixtures
{
    public class SuccessfulOutcomeAdapter : IAdapter
    {
        public Task<FileRepresentation> TouchFileAsync(
            TouchFileRequest touchFileRequest,
            CancellationToken cancellationToken
        )
        {
            return Task.FromResult(new FileRepresentation());
        }
    }
}
