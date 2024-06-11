using Task10.Exceptions;
using Task10.Models;
using Task10.Repositories;

namespace Task10.Services;

public class PatientService : IPatientService
{
    private IPatientRepository _patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }
    public async Task<GetPatientDto> GetPatientDataAsync(int idPatient)
    {
        var patient = await _patientRepository.PatientExistsAsync(idPatient);
        if (!patient)
        {
            throw new DoesntExistException("Patient doesnt exist");
        }
        return await _patientRepository.GetPatientDataAsync(idPatient);
    }
}