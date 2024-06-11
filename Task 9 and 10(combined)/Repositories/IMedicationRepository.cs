using Task10.Models;

namespace Task10.Repositories;

public interface IMedicationRepository
{
    public Task<bool> MedicationExistsAsync(MedicamentDto medicamentDto);
}