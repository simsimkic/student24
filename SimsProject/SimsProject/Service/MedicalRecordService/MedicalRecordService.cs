/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.MedicalRecordService
 ***********************************************************************/

using Model.MedicalRecord;
using System;
using System.Collections.Generic;
using Repository.MedicalRecordRepository;
using SimsProject.Repository.MedicalRecordRepository;
using Model.User;

namespace Service.MedicalRecordService
{
   public class MedicalRecordService
   {
      public int number = 0;
      public MedicalRecord CreateRecord(Patient patient)
      {
            imedicalRecordRepository = new MedicalRecordRepository("../../Fajlovi/kartoni.xml");
            
            number = getLastRecordNumber();

            MedicalRecord record = new MedicalRecord
            {
               patient=patient,
               recordNumber = ++number
            };

            return imedicalRecordRepository.save(record);
        }
        public int getLastRecordNumber()
        {
            int num = 0;
            imedicalRecordRepository = new MedicalRecordRepository("../../Fajlovi/kartoni.xml");

            List<MedicalRecord>  medicalRecordsList = imedicalRecordRepository.getAll();
            foreach (var r in medicalRecordsList)
            {
                num = r.recordNumber;
            }
            return num;
        }
        public MedicalRecord EditRecord(MedicalRecord record)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteRecord(Model.MedicalRecord.MedicalRecord record)
      {
         // TODO: implement
      }
      
      public MedicalRecord GetRecord(String username)
      {
         // TODO: implement
         return null;
      }
   
      
      public IMedicalRecordRepository imedicalRecordRepository;

      public RecipeService recipeService;
      public RefferalToSpecialistService refferalToSpecialistService;
      public TherapyService therapyService;
      public HospitalStayService hospitalStayService;
   
   }
}