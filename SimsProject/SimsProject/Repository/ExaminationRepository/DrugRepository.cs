/***********************************************************************
 * Module:  DrugRepository.cs
 * Purpose: Definition of the Class Service.DrugService.DrugRepository
 ***********************************************************************/

using Model.Examination;
using SimsProject.Repository.ExaminationRepository;
using SimsProject.Repository.GenericRepository;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationRepository
{
   public class DrugRepository : GenericRepository<Drug>, IDrugRepository
    {
      public DrugRepository(String filePath) : base(filePath) { }
 
      public Drug GetById(int id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Drug> GetDrugsForValidation(String type)
      {
         // TODO: implement
         return null;
      }
      
      private String path;
   
   }
}