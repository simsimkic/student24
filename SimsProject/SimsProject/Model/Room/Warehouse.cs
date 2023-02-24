/***********************************************************************
 * Module:  Warehouse.cs
 * Purpose: Definition of the Class Model.Room.Warehouse
 ***********************************************************************/

using System;

namespace Model.Room
{
   public class Warehouse : Room
   {
      public System.Collections.ArrayList suppliesOfDrug;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetSuppliesOfDrug()
      {
         if (suppliesOfDrug == null)
            suppliesOfDrug = new System.Collections.ArrayList();
         return suppliesOfDrug;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetSuppliesOfDrug(System.Collections.ArrayList newSuppliesOfDrug)
      {
         RemoveAllSuppliesOfDrug();
         foreach (SuppliesOfDrug oSuppliesOfDrug in newSuppliesOfDrug)
            AddSuppliesOfDrug(oSuppliesOfDrug);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddSuppliesOfDrug(SuppliesOfDrug newSuppliesOfDrug)
      {
         if (newSuppliesOfDrug == null)
            return;
         if (this.suppliesOfDrug == null)
            this.suppliesOfDrug = new System.Collections.ArrayList();
         if (!this.suppliesOfDrug.Contains(newSuppliesOfDrug))
            this.suppliesOfDrug.Add(newSuppliesOfDrug);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveSuppliesOfDrug(SuppliesOfDrug oldSuppliesOfDrug)
      {
         if (oldSuppliesOfDrug == null)
            return;
         if (this.suppliesOfDrug != null)
            if (this.suppliesOfDrug.Contains(oldSuppliesOfDrug))
               this.suppliesOfDrug.Remove(oldSuppliesOfDrug);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllSuppliesOfDrug()
      {
         if (suppliesOfDrug != null)
            suppliesOfDrug.Clear();
      }
   
      private String name = "Warehouse";
   
   }
}