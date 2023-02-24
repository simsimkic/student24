/***********************************************************************
 * Module:  RefferalToSpecialistRepository.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.RefferalToSpecialistRepository
 ***********************************************************************/

using Model.Examination;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Repository.MedicalRecordRepository
{
   public class RefferalToSpecialistRepository : GenericRepository<RefferalToSpecialist>, IRefferalToSpecialistRepository
    {

        public RefferalToSpecialistRepository(String filePath) : base(filePath) { }
        public RefferalToSpecialist GetRefferalToSpecialist(int id)
        {
         // TODO: implement
         return null;
        }

      private String path;
   
   }
}