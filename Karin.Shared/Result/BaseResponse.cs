namespace Karin.Shared.Result
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }

        public static BaseResponse<T> CreateSuccess(T? data, string message = null)
        {
            return new BaseResponse<T> { Success = true, Data = data, Message = message };
        }

        public static BaseResponse<T> CreateFailure(string message)
        {
            return new BaseResponse<T> { Success = false, Data = default, Message = message };
        }
    }
}