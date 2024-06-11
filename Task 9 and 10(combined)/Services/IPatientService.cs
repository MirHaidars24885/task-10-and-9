using Task10.Models;

namespace Task10.Services;

public interface IPatientService
{
    public Task<GetPatientDto> GetPatientDataAsync(int idPatient);
}