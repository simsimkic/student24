/***********************************************************************
 * Module:  RecipeRepository.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.RecipeRepository
 ***********************************************************************/

using Model.Examination;
using SimsProject.Repository.GenericRepository;
using SimsProject.Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Repository.MedicalRecordRepository
{
   public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
    {

        public RecipeRepository(String filePath) : base(filePath) { }
        public Recipe GetRecipe(int id)
        {
         // TODO: implement
         return null;
        }
      
      private String path;
   
   }
}