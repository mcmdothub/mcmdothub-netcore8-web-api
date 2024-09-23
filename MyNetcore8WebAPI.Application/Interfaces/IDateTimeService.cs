using System;

namespace MyNetcore8WebAPI.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}