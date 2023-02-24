/***********************************************************************
 * Module:  DocumentService.cs
 * Purpose: Definition of the Class Service.ExaminationService.DocumentService
 ***********************************************************************/

using Model.Examination;
using System;
using System.Collections.Generic;

namespace Controller.MedicalRecordController
{
   public class RecipeController
   {
      public Model.Examination.Recipe CreateRecipe(Model.Examination.Recipe recipe)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Examination.Recipe GetRecipe(Model.Examination.Recipe recipe)
      {
         // TODO: implement
         return null;
      }
      
      public List<Recipe> GetAllRecipe(int recordNumber)
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList recipeService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRecipeService()
      {
         if (recipeService == null)
            recipeService = new System.Collections.ArrayList();
         return recipeService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRecipeService(System.Collections.ArrayList newRecipeService)
      {
         RemoveAllRecipeService();
         foreach (Service.MedicalRecordService.RecipeService oRecipeService in newRecipeService)
            AddRecipeService(oRecipeService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRecipeService(Service.MedicalRecordService.RecipeService newRecipeService)
      {
         if (newRecipeService == null)
            return;
         if (this.recipeService == null)
            this.recipeService = new System.Collections.ArrayList();
         if (!this.recipeService.Contains(newRecipeService))
            this.recipeService.Add(newRecipeService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRecipeService(Service.MedicalRecordService.RecipeService oldRecipeService)
      {
         if (oldRecipeService == null)
            return;
         if (this.recipeService != null)
            if (this.recipeService.Contains(oldRecipeService))
               this.recipeService.Remove(oldRecipeService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRecipeService()
      {
         if (recipeService != null)
            recipeService.Clear();
      }
   
   }
}