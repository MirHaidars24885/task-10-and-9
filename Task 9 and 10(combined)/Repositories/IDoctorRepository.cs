namespace Task10.Repositories;

public interface IDoctorRepository
{
    public Task<bool> DoctorExistsAsync(int idDoctor);
}