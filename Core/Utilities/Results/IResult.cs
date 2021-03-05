using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç. Yani data yok bişey döndürmiycek.
    public interface IResult
    {
        bool Success { get; } //Sadece okunabilir demek.
        string Message { get; }
    }
}
