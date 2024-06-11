using Task10.Models;

namespace Task10.Services;

public interface IPrescriptionService
{
    public Task AddPrescriptionAsync(AssignPrescriptionDto assignPrescriptionDto);
}