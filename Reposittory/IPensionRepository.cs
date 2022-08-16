using PensionMicroService.Models;

namespace PensionMicroService.Reposittory
{
    public interface IPensionRepository
    {
        Task<PensionModel> GetPensioner(double aadhar);
        Task<List<PensionModel>> GetAllPensioners();

        Task<PensionModel> GetAllDetails(String Name);
    }
}
