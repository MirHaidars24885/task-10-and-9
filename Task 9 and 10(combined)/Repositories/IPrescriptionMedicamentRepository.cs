using Task10.Models;

namespace Task10.Repositories;

public interface IPrescriptionMedicamentRepository
{
    public Task<int> AddToPrescriptionMedicamentAsync(IEnumerable<MedicamentDto> medicaments, int idPrescription);
}