/***********************************************************************
 * Module:  MedicalRecordRepository.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.MedicalRecordRepository
 ***********************************************************************/

using Model.MedicalRecord;
using SimsProject.helpers;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Repository.MedicalRecordRepository
{
   public class MedicalRecordRepository : GenericRepository<MedicalRecord>, IMedicalRecordRepository
    {
       
      public MedicalRecordRepository(String filePath) : base(filePath){}
      
      public MedicalRecord GetRecord(String username)
      {
         // TODO: implement
         return null;
      }
      
     
      private string path;
   
   }
}