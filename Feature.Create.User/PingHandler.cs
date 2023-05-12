using MediatR;

namespace Feature.Create.User
{
    public class PingHandler : IRequestHandler<PingHandler.PingRequest, string>
    {
        public class PingRequest : IRequest<string>
        {
        }

        public async Task<string> Handle(PingRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult("Pong");
        }
    }
}
