﻿using Marqa.Service.Services.Companies.Models;

namespace Marqa.Service.Services.Companies;

public interface ICompanyService
{
    Task CreateAsync(CompanyCreateModel model);
    Task UpdateAsync(int id, CompanyUpdateModel model);
    Task DeleteAsync(int id);
    Task<CompanyViewModel> GetAsync(int id);
    Task<List<CompanyViewModel>> GetAllAsync();
}