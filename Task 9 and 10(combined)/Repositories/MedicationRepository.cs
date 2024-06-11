using Microsoft.EntityFrameworkCore;
using Task10.Context;
using Task10.Models;

namespace Task10.Repositories;

public class MedicationRepository : IMedicationRepository
{
    private MedicalContext _medicalContext;

    public MedicationRepository(MedicalContext medicalContext)
    {
        _medicalContext = medicalContext;
    }

    public async Task<bool> MedicationExistsAsync(MedicamentDto medicamentDtos)
    {
        var medicationExists = await _medicalContext.Medicaments
            .FirstOrDefaultAsync(m => m.IdMedicament == medicamentDtos.IdMedicament);

        return medicationExists != null;
    }
}