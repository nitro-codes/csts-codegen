using CsTsCoder.Shared;
using System.ComponentModel;

namespace CsTsCoder.Spin.Csharp.Dtos.Shared.Enums
{
    [CoderEnabled]
    public enum Company
    {
        [Description("CocaCola")]
        CocaCola = 1,
        [Description("Ford")]
        Ford = 2,
    }
}