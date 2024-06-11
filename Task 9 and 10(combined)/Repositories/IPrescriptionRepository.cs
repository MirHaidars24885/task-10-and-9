using Task10.Models;

namespace Task10.Repositories;

public interface IPrescriptionRepository
{
    public Task<int> AddPrescriptionAsync(AssignPrescriptionDto assignPrescriptionDto, int doctorId, int patientId);

}