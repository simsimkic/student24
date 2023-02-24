/***********************************************************************
 * Module:  Karton.cs
 * Purpose: Definition of the Class Pregled.Karton
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.MedicalRecord
{
   public class MedicalRecord : Entity
    {
      public System.Collections.ArrayList hospitalStay;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetHospitalStay()
      {
         if (hospitalStay == null)
            hospitalStay = new System.Collections.ArrayList();
         return hospitalStay;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetHospitalStay(System.Collections.ArrayList newHospitalStay)
      {
         RemoveAllHospitalStay();
         foreach (HospitalStay oHospitalStay in newHospitalStay)
            AddHospitalStay(oHospitalStay);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddHospitalStay(HospitalStay newHospitalStay)
      {
         if (newHospitalStay == null)
            return;
         if (this.hospitalStay == null)
            this.hospitalStay = new System.Collections.ArrayList();
         if (!this.hospitalStay.Contains(newHospitalStay))
            this.hospitalStay.Add(newHospitalStay);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveHospitalStay(HospitalStay oldHospitalStay)
      {
         if (oldHospitalStay == null)
            return;
         if (this.hospitalStay != null)
            if (this.hospitalStay.Contains(oldHospitalStay))
               this.hospitalStay.Remove(oldHospitalStay);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllHospitalStay()
      {
         if (hospitalStay != null)
            hospitalStay.Clear();
      }
      public System.Collections.ArrayList examination;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetExamination()
      {
         if (examination == null)
            examination = new System.Collections.ArrayList();
         return examination;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetExamination(System.Collections.ArrayList newExamination)
      {
         RemoveAllExamination();
         foreach (Model.Examination.Examination oExamination in newExamination)
            AddExamination(oExamination);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddExamination(Model.Examination.Examination newExamination)
      {
         if (newExamination == null)
            return;
         if (this.examination == null)
            this.examination = new System.Collections.ArrayList();
         if (!this.examination.Contains(newExamination))
            this.examination.Add(newExamination);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveExamination(Model.Examination.Examination oldExamination)
      {
         if (oldExamination == null)
            return;
         if (this.examination != null)
            if (this.examination.Contains(oldExamination))
               this.examination.Remove(oldExamination);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllExamination()
      {
         if (examination != null)
            examination.Clear();
      }
      public System.Collections.ArrayList recipe;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRecipe()
      {
         if (recipe == null)
            recipe = new System.Collections.ArrayList();
         return recipe;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRecipe(System.Collections.ArrayList newRecipe)
      {
         RemoveAllRecipe();
         foreach (Model.Examination.Recipe oRecipe in newRecipe)
            AddRecipe(oRecipe);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRecipe(Model.Examination.Recipe newRecipe)
      {
         if (newRecipe == null)
            return;
         if (this.recipe == null)
            this.recipe = new System.Collections.ArrayList();
         if (!this.recipe.Contains(newRecipe))
            this.recipe.Add(newRecipe);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRecipe(Model.Examination.Recipe oldRecipe)
      {
         if (oldRecipe == null)
            return;
         if (this.recipe != null)
            if (this.recipe.Contains(oldRecipe))
               this.recipe.Remove(oldRecipe);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRecipe()
      {
         if (recipe != null)
            recipe.Clear();
      }
      public System.Collections.ArrayList therapy;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetTherapy()
      {
         if (therapy == null)
            therapy = new System.Collections.ArrayList();
         return therapy;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetTherapy(System.Collections.ArrayList newTherapy)
      {
         RemoveAllTherapy();
         foreach (Model.Examination.Therapy oTherapy in newTherapy)
            AddTherapy(oTherapy);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddTherapy(Model.Examination.Therapy newTherapy)
      {
         if (newTherapy == null)
            return;
         if (this.therapy == null)
            this.therapy = new System.Collections.ArrayList();
         if (!this.therapy.Contains(newTherapy))
            this.therapy.Add(newTherapy);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveTherapy(Model.Examination.Therapy oldTherapy)
      {
         if (oldTherapy == null)
            return;
         if (this.therapy != null)
            if (this.therapy.Contains(oldTherapy))
               this.therapy.Remove(oldTherapy);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllTherapy()
      {
         if (therapy != null)
            therapy.Clear();
      }
      public System.Collections.ArrayList refferalToSpecialist;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRefferalToSpecialist()
      {
         if (refferalToSpecialist == null)
            refferalToSpecialist = new System.Collections.ArrayList();
         return refferalToSpecialist;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRefferalToSpecialist(System.Collections.ArrayList newRefferalToSpecialist)
      {
         RemoveAllRefferalToSpecialist();
         foreach (Model.Examination.RefferalToSpecialist oRefferalToSpecialist in newRefferalToSpecialist)
            AddRefferalToSpecialist(oRefferalToSpecialist);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRefferalToSpecialist(Model.Examination.RefferalToSpecialist newRefferalToSpecialist)
      {
         if (newRefferalToSpecialist == null)
            return;
         if (this.refferalToSpecialist == null)
            this.refferalToSpecialist = new System.Collections.ArrayList();
         if (!this.refferalToSpecialist.Contains(newRefferalToSpecialist))
            this.refferalToSpecialist.Add(newRefferalToSpecialist);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRefferalToSpecialist(Model.Examination.RefferalToSpecialist oldRefferalToSpecialist)
      {
         if (oldRefferalToSpecialist == null)
            return;
         if (this.refferalToSpecialist != null)
            if (this.refferalToSpecialist.Contains(oldRefferalToSpecialist))
               this.refferalToSpecialist.Remove(oldRefferalToSpecialist);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRefferalToSpecialist()
      {
         if (refferalToSpecialist != null)
            refferalToSpecialist.Clear();
      }

      public Model.User.Patient patient;
      public int recordNumber=0;
   
   }
}