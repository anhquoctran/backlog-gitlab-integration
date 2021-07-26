using System;
using System.Collections.Generic;
using System.Text;

namespace BacklogGitLabIntegration.Core.Shared.Models.Concrete
{
    public interface IHasCreationTime: IHasCreationTime<int>
    {
    }

    public interface IHasCreationTime<TTimeType>
    {
        TTimeType CreationTime { get; set; }
    }
}
