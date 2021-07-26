using System;
using System.Collections.Generic;
using System.Text;

namespace BacklogGitLabIntegration.Core.Shared.Models.Concrete
{
    public class Entity: Entity<int> { }

    public class Entity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
