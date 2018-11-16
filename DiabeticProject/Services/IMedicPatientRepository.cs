﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticProject.Model;
using DiabeticProject.Models.MedicPatientRepo;
using Microsoft.AspNetCore.Mvc;
 


namespace DiabeticProject.Services
{
   public interface IMedicPatientRepository
   {
       IEnumerable<Patient> GetPatients();
       Task<IActionResult> GetPatient( int id);
       Task<IActionResult> PutPatient(int id, Patient patient);
       Task<IActionResult> PostPatient(Patient patient);
       Task<IActionResult> DeletePatient(int id);
       bool PatientExists(int id);
   }
}

