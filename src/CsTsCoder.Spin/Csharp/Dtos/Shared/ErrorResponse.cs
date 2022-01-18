using CsTsCoder.Shared;

namespace CsTsCoder.Spin.Csharp.Dtos.Shared
{
    [CoderEnabled]
    public class ErrorResponse
    {
        public string[] Errors { get; set; }
    }
}