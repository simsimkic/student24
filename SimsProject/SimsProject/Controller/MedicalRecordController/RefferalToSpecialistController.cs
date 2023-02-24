/***********************************************************************
 * Module:  RefferalToSpecialistService.cs
 * Purpose: Definition of the Class Service.MedicalRecordService.RefferalToSpecialistService
 ***********************************************************************/

using Model.Examination;
using System;
using System.Collections.Generic;

namespace Controller.MedicalRecordController
{
   public class RefferalToSpecialistController
   {
      public Model.Examination.RefferalToSpecialist CreateRefferalToSpecialist(Model.Examination.RefferalToSpecialist refferal)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Examination.RefferalToSpecialist GetRefferalToSpecialist(Model.Examination.RefferalToSpecialist refferal)
      {
         // TODO: implement
         return null;
      }
      
      public List<RefferalToSpecialist> GetAllRefferalToSpecialist()
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList refferalToSpecialistService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRefferalToSpecialistService()
      {
         if (refferalToSpecialistService == null)
            refferalToSpecialistService = new System.Collections.ArrayList();
         return refferalToSpecialistService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRefferalToSpecialistService(System.Collections.ArrayList newRefferalToSpecialistService)
      {
         RemoveAllRefferalToSpecialistService();
         foreach (Service.MedicalRecordService.RefferalToSpecialistService oRefferalToSpecialistService in newRefferalToSpecialistService)
            AddRefferalToSpecialistService(oRefferalToSpecialistService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRefferalToSpecialistService(Service.MedicalRecordService.RefferalToSpecialistService newRefferalToSpecialistService)
      {
         if (newRefferalToSpecialistService == null)
            return;
         if (this.refferalToSpecialistService == null)
            this.refferalToSpecialistService = new System.Collections.ArrayList();
         if (!this.refferalToSpecialistService.Contains(newRefferalToSpecialistService))
            this.refferalToSpecialistService.Add(newRefferalToSpecialistService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRefferalToSpecialistService(Service.MedicalRecordService.RefferalToSpecialistService oldRefferalToSpecialistService)
      {
         if (oldRefferalToSpecialistService == null)
            return;
         if (this.refferalToSpecialistService != null)
            if (this.refferalToSpecialistService.Contains(oldRefferalToSpecialistService))
               this.refferalToSpecialistService.Remove(oldRefferalToSpecialistService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRefferalToSpecialistService()
      {
         if (refferalToSpecialistService != null)
            refferalToSpecialistService.Clear();
      }
   
      private int RecordNumber;
   
   }
}