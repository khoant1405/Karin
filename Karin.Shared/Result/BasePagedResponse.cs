namespace Shared.Result
{
    public class BasePagedResponse<T> : BaseResponse<IEnumerable<T>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalRecords / PageSize);

        public static BasePagedResponse<T> Create(IEnumerable<T> data, int pageNumber, int pageSize, int totalRecords)
        {
            return new BasePagedResponse<T>
            {
                Success = true,
                Data = data,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = totalRecords
            };
        }
    }
}
