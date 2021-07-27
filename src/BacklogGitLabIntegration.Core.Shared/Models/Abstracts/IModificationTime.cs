using System;
using System.Collections.Generic;
using System.Text;

namespace BacklogGitLabIntegration.Core.Shared.Models.Abstracts
{
    public interface IMofificationTime : IHasCreationTime<int>
    {
    }

    public interface IMofificationTime<TTimeType>
    {
        TTimeType ModificationTime { get; set; }
    }
}
