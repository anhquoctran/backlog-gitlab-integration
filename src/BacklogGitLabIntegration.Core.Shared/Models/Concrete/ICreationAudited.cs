
namespace BacklogGitLabIntegration.Core.Shared.Models.Concrete
{
    public interface ICreationAudited: ICreationAudited<int> { }

    public interface ICreationAudited<TPrimaryKey> : IHasCreationTime
    {
        TPrimaryKey CreatorId { get; set; }
    }
}
