﻿using CreaMT.Application.UseCases.Usuario.Register;
using CreaMT.Communication.Requests;
using CreaMT.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CreaMT.API.Controllers;
[Route("[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUsuariosJson),StatusCodes.Status201Created)]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterUsuarioUseCase useCase,
        [FromBody] RequestRegisterUsuarioJson request)
    {
        var resul = await useCase.Execute(request);
        return Created(string.Empty, resul);
    }
}
