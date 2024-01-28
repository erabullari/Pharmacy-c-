
using Pharmacy.Services;
using Iservice;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Data.Models;

namespace Pharmacy.Services
{
    public class MedicinesService : IMedicineService
    {


        private AppDbContext _dbContext;
        public MedicinesService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteMedicineById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteMedicineByIdAsync(int id)
        {
            var medicineFromDb = await _dbContext.Medicines.FirstOrDefaultAsync(x => x.med_id == id);

            if (medicineFromDb != null)
            {
                _dbContext.Medicines.Remove(medicineFromDb);
                await _dbContext.SaveChangesAsync();
            }
        }

        public object GetMedicines()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Medicine>> GetMedicineAsync()
        {
            var allMedicines = await _dbContext.Medicines.ToListAsync();
            return allMedicines;
        }

        public object GetyIdMedicineAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Medicine> GetMedicineByIdAsync(int id)
        {
            var medicineFromDb = await _dbContext.Medicines.FirstOrDefaultAsync(x => x.med_id == id);
            return medicineFromDb;
        }

        public void PostMedicine(PostMedicine payload)
        {
            throw new NotImplementedException();
        }

        public async Task PostMedicineAsync(PostMedicine medicine)
        {
            //1. Krijohet objekti
            var newMedicine = new Medicine()
            {
                med_name = medicine.med_name,
                med_expired_date = medicine.med_expired_date,
                med_produced_by = medicine.med_produced_by,
                med_description = medicine.med_description

            };


            await _dbContext.Medicines.AddAsync(newMedicine);
            await _dbContext.SaveChangesAsync();
        }

        public void UpdateMedicine(int id, PutMedicine payload)
        {
            throw new NotImplementedException();
        }
        public object GetMedicineById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMediciney(int id, PutMedicine payload)
        {
            throw new NotImplementedException();
        }
        public async Task<Medicine> UpdateMedicineAsync(int id, PutMedicine medicine)
        {
            var medicineFromDb = await _dbContext.Medicines.FirstOrDefaultAsync(x => x.med_id == id);

            if (medicineFromDb != null)
            {
                medicineFromDb.med_name = medicine.med_name;
                medicineFromDb.med_expired_date = medicine.med_expired_date;
                medicineFromDb.med_produced_by = medicine.med_produced_by;
                medicineFromDb.med_description = medicine.med_description;

                await _dbContext.SaveChangesAsync();
            }

            return medicineFromDb;
        }
    }
}
