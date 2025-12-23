using System.Net;

namespace Application.Bases_Response
{
    public class ResponseHandler
    {
        public ResponseHandler()
        {

        }
        public DataResponse<T> Deleted<T>()
        {
            return new DataResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Successded = true,
                Message = "Deleted successfully",
            };
        }
        public DataResponse<T> NotFound<T>(string message)
        {
            return new DataResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Successded = false,
                Message = message,
            };
        }
        public DataResponse<T> Success<T>(T entity, object? meta = null)
        {
            return new DataResponse<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Successded = true,
                Meta = meta,
                Message = "Operation Successfuly",
            };
        }
        public DataResponse<T> Failure<T>(string message, List<string>? errors = null)
        {
            return new DataResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Successded = false,
                Message = message,
                Errors = errors ?? new List<string>(),
            };
        }
        public DataResponse<T> Created<T>(T entity)
        {
            return new DataResponse<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Successded = true,
                Message = "Created successfully",
            };
        }
        public DataResponse<T> Updated<T>(T entity)
        {
            return new DataResponse<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Successded = true,
                Message = "Updated successfully",
            };
        }
        public DataResponse<T> UnAuthorized<T>()
        {
            return new DataResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Successded = false,
                Message = "UnAuthorized",
            };
        }
        public DataResponse<T> Forbidden<T>()
        {
            return new DataResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Forbidden,
                Successded = false,
                Message = "Forbidden",
            };
        }
        public DataResponse<T> Conflict<T>()
        {
            return new DataResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Conflict,
                Successded = false,
                Message = "Conflict",
            };
        }
        public DataResponse<T> InternalServerError<T>()
        {
            return new DataResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.InternalServerError,
                Successded = false,
                Message = " InternalServerError 500 ",
            };
        }
        public DataResponse<T> BadRequest<T>()
        {
            return new DataResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Successded = false,
                Message = "Bad Request",
            };
        }
        public DataResponse<T> CustomResponse<T>(HttpStatusCode statusCode, bool successded, string message, T data = default!)
        {
            return new DataResponse<T>()
            {
                StatusCode = statusCode,
                Successded = successded,
                Message = message,
                Data = data
            };
        }


    }
}
