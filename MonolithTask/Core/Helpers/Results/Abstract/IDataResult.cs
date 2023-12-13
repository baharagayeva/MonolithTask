
namespace Core.Helpers

{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
