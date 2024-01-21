

using Pharmacy.Services;
using Iservice;
using Pharmacy.Data.Model;
using Pharmacy.Data;
using Microsoft.EntityFrameworkCore;


namespace Pharmacy.Services
{
    public class MedicinesService : Iservices
    {
       

        private AppDbContext _dbContext;

        public MedicinesService(AppDbContext dbContext)

        {
            _dbContext = dbContext;
        }


        public async Task PostMedicineAsync(PostMedicine medicine)

        {
            var newMedicine = new Medicine()
            {
                med_name = medicine.med_name,
             
                med_description = medicine.med_description
            };

            await _dbContext.Medicines.AddAsync(newMedicine);
            await _dbContext.SaveChangesAsync();
        }

        

        public async Task<Medicine> UpdateMedicineAsync(int id, PutMedicine medicine)
        {
            var medicineFromDb = await _dbContext.Medicines.FirstOrDefaultAsync(x => x.med_id == id);
            if (medicineFromDb != null)
            {
                medicineFromDb.med_name = medicine.med_name;
                medicineFromDb.med_price = medicine.med_price;
                medicineFromDb.med_description = medicine.med_description;

                await _dbContext.SaveChangesAsync();
            }

            return medicineFromDb;
        }
    }
}
