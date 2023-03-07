namespace TaskClassification.Business.Features
{
    public class BaseResponse
    {
        public bool IsSuccessful { get; set; } = true;
        public string Message { get; set; }

        public void ToFailed(string message)
        {
            IsSuccessful = false;
            Message = message;
        }
    }

    public class BaseResponse<T> : BaseResponse
    {
        public T Result { get; set; }
    }
}
