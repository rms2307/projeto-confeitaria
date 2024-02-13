using System.Diagnostics.CodeAnalysis;

namespace Confeitaria.Api.Exceptions
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class NotFoundException : Exception
    {
        public NotFoundException() { }

        public NotFoundException(string message) : base(message) { }
    }
}
