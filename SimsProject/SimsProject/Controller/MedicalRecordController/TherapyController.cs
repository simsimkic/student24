/***********************************************************************
 * Module:  TherapyService.cs
 * Purpose: Definition of the Class Service.ExaminationService.TherapyService
 ***********************************************************************/

using Model.Examination;
using System;
using System.Collections.Generic;

namespace Controller.MedicalRecordController
{
   public class TherapyController
   {
      public Model.Examination.Therapy AddTherapy(Model.Examination.Therapy therapy)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Examination.Therapy EditTherapy(Model.Examination.Therapy therapy)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Examination.Therapy GetTherapyById(int id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Therapy> GetTherapyByPatient(Model.User.Patient patient)
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList therapyService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetTherapyService()
      {
         if (therapyService == null)
            therapyService = new System.Collections.ArrayList();
         return therapyService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetTherapyService(System.Collections.ArrayList newTherapyService)
      {
         RemoveAllTherapyService();
         foreach (Service.MedicalRecordService.TherapyService oTherapyService in newTherapyService)
            AddTherapyService(oTherapyService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddTherapyService(Service.MedicalRecordService.TherapyService newTherapyService)
      {
         if (newTherapyService == null)
            return;
         if (this.therapyService == null)
            this.therapyService = new System.Collections.ArrayList();
         if (!this.therapyService.Contains(newTherapyService))
            this.therapyService.Add(newTherapyService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveTherapyService(Service.MedicalRecordService.TherapyService oldTherapyService)
      {
         if (oldTherapyService == null)
            return;
         if (this.therapyService != null)
            if (this.therapyService.Contains(oldTherapyService))
               this.therapyService.Remove(oldTherapyService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllTherapyService()
      {
         if (therapyService != null)
            therapyService.Clear();
      }
   
   }
}