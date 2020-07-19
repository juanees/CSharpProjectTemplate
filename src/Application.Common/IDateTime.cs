using System;

namespace Application.Common
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
        DateTime LocalNow { get; }
    }
}
