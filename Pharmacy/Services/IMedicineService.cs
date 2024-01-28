
using Pharmacy.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Iservice;
using Pharmacy.Data.Models;

namespace Iservice
{
    public interface IMedicineService
    {
        Task<List<Medicine>> GetMedicineAsync();
        Task<Medicine> GetMedicineByIdAsync(int id);
        Task PostMedicineAsync(PostMedicine medicine);
        Task<Medicine> UpdateMedicineAsync(int id, PutMedicine medicine);
        Task DeleteMedicineByIdAsync(int id);
        object GetMedicines();
        object GetMedicineById(int id);
        void DeleteMedicineById(int id);
        void PostMedicine(PostMedicine payload);
        void UpdateMediciney(int id, PutMedicine payload);
    }

    
}

