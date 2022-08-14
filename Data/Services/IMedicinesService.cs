using sanjay_cp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sanjay_cp.Data.Services
{
   public interface IMedicinesService
    {
        Task<IEnumerable<Medicine>> GetAll();
        Task<Medicine> GetByID(int id);
        Task Add(Medicine medicine);
        Task<Medicine> Update(int id, Medicine newMedicine);
        Task Delete(int id);
        
    }
}
