using Tutorial10.DTO;
namespace Tutorial10.Service
{
    using System.Threading.Tasks;

    public interface IDbService
    {
        Task<PrescriptionDetailsDto> AddPrescriptionAsync(PrescriptionRequestDto prescriptionDto);
        Task<PatientDto> GetPatientAsync(int patientId);
    }
}