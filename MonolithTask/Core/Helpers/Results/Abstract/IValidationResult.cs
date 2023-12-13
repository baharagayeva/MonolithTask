using System.Collections.Generic;

namespace Core.Helpers
{
    public interface IValidationResult
    {
        bool IsValid { get; }
        List<string> Errors { get; }
    }
}
