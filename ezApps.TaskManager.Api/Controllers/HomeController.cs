﻿using Microsoft.AspNetCore.Mvc;

namespace ezApps.TaskManager.Api.Controllers;

[Route("")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Welcome to Identity Service API! Navigate to /swagger for API documentation.");
    }
}