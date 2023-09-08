using Microsoft.AspNetCore.Mvc;

using ServiceA.Models;

namespace ServiceA.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    private readonly ILogger<MathController> _logger;

    public MathController(ILogger<MathController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{a}/{b}", Name = "Sum")]
    public SumDto Sum(int a, int b)
    {
        return new SumDto { A = a, B = b, Sum = a + b };
    }

    [HttpGet("{a}/{b}", Name = "Multiply")]
    public MultDto Multiply(int a, int b)
    {
        return new MultDto { A = a, B = b, Mult = a * b };
    }
}