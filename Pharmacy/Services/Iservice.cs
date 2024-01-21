
using Pharmacy.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Pharmacy.Data.Model;
using Iservice;

namespace Iservice
{
    public interface Iservice
    {
        Task<List<Medicine>> GetMedicineAsync();
        Task<Medicine> GetyIdMedicine(int id);
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

