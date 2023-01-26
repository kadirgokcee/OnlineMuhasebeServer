namespace Application.Features.AppFeatures.AuthFeatures.Queries;
public sealed record GetRolesByUserIdAndCompanyIdQueryResponse(
    IList<string> Roles);