
using topMedic.Domain.Models;
using topMedic.Domain.Services;
using topMedic.EntityFramework;
using topMedic.EntityFramework.Services;

IDataService<Patient> patientService = new GenericDataService<Patient>(new TopMedicDbContextFactory());

patientService.Create(new Patient { FirstName = "Michel", LastName = "Garbouille", Email = "michel.garbouille@gmail.com", BloodGroup = "0", Phone = "0766765432" }).Wait();

patientService.Update(1, new Patient { FirstName = "BONJO", LastName = "Garbouille", Email = "michel.garbouille@gmail.com", BloodGroup = "0", Phone = "0766765432" }).Wait();

Console.WriteLine(patientService.GetAll().Result.Count() + " patients!");

Console.ReadLine();