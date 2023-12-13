
namespace Core.Helpers
{
    public interface IResult
    {
        string Message { get; }
        bool IsSuccess { get; }
    }
}
