using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Task10.Exceptions;
using Task10.Models;
using Task10.Services;

namespace Task10.Controllers;
[ApiController]
[Authorize]
[Route("api/patients")]
public class PatientController : ControllerBase
{
    private IPatientService _patientService;

    public PatientController(IPatientService patientService)
    {
        _patientService = patientService;
    }
    [HttpGet("{idPatient}")]
    public async Task<IActionResult> GetPatientData(int idPatient)
    {
        var patientData = await _patientService.GetPatientDataAsync(idPatient);
        
        return Ok(patientData);
    }
}