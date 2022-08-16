using Microsoft.EntityFrameworkCore;
using PensionMicroService.Models;

namespace PensionMicroService.Reposittory
{
    public class PensionRepository : IPensionRepository
    {
        private readonly PensionContext _context;
        public PensionRepository(PensionContext pensioncontext)
        {
            _context = pensioncontext;
        }

        public  async Task<List<PensionModel>> GetAllPensioners()
        {
            var pensioners = await _context.Pensioner.Include("BankDetails").ToListAsync(); 
            return pensioners;
        }

        public async Task<PensionModel> GetPensioner(double aadhar)
        {

            var details= await _context.Pensioner.Include("BankDetails").Where(x=>x.Aadhaarcard==aadhar).FirstOrDefaultAsync();
              
            return details;
        }

        public async Task<PensionModel> GetAllDetails(String Name)
        {
            var details = await _context.Pensioner.Include("BankDetails").Where(x => x.Name == Name).FirstOrDefaultAsync();
            return details;
        }

       

    }
}
