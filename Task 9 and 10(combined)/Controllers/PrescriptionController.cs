using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Task10.Exceptions;
using Task10.Models;
using Task10.Services;

namespace Task10.Controllers;
[ApiController]
[Authorize]
[Route("api/prescriptions")]
public class PrescriptionController : ControllerBase
{
    private IPrescriptionService _prescriptionService;

    public PrescriptionController(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;
    }

    [HttpPost]
    public async Task<IActionResult> AddPrescription(AssignPrescriptionDto assignPrescriptionDto)
    {
        await _prescriptionService.AddPrescriptionAsync(assignPrescriptionDto);
        
        return NoContent();
    }
}