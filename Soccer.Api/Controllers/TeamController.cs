using AuthenticationServices.Helpers;
using AutoMapper;
using CommonGenericClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Soccer.Shared.Dtos;
using Soccer.Shared.Entities;
using Soccer.Shared.UnitsOfWork;

namespace Soccer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(AuthenticationSchemes = "Bearer")]

public class TeamController : BaseController<Team, TeamDto>
{
    public TeamController(ITeamUnitOfWork unitOfWork, IMapper mapper, FluentValidation.AbstractValidator<Team> validator) : base(unitOfWork, mapper, validator)
    {
    }
    [Authorize(Roles = Roles.User)]
    public override Task<IActionResult> Get() => base.Get();
    [Authorize(Roles = Roles.User)]
    public override Task<IActionResult> Get(Guid id) => base.Get(id);
    [Authorize(Roles = Roles.Admin)]
    public override Task<IActionResult> Post(TeamDto dto) => base.Post(dto);
    [Authorize(Roles = Roles.Admin)]
    public override Task<IActionResult> Put(Team team) => base.Put(team);
    [Authorize(Roles = Roles.Admin)]
    public override Task<ActionResult> Delete(Guid id) => base.Delete(id);
}
