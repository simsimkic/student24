/***********************************************************************
 * Module:  Prostorija.cs
 * Purpose: Definition of the Class Upravnik.Prostorija
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.Room
{
    public class Room:Entity
    {
        public System.Collections.ArrayList suppliesOfEquipment;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetSuppliesOfEquipment()
        {
            if (suppliesOfEquipment == null)
                suppliesOfEquipment = new System.Collections.ArrayList();
            return suppliesOfEquipment;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetSuppliesOfEquipment(System.Collections.ArrayList newSuppliesOfEquipment)
        {
            RemoveAllSuppliesOfEquipment();
            foreach (SuppliesOfEquipment oSuppliesOfEquipment in newSuppliesOfEquipment)
                AddSuppliesOfEquipment(oSuppliesOfEquipment);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddSuppliesOfEquipment(SuppliesOfEquipment newSuppliesOfEquipment)
        {
            if (newSuppliesOfEquipment == null)
                return;
            if (this.suppliesOfEquipment == null)
                this.suppliesOfEquipment = new System.Collections.ArrayList();
            if (!this.suppliesOfEquipment.Contains(newSuppliesOfEquipment))
            {
                this.suppliesOfEquipment.Add(newSuppliesOfEquipment);
                newSuppliesOfEquipment.SetRoom(this);
            }
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveSuppliesOfEquipment(SuppliesOfEquipment oldSuppliesOfEquipment)
        {
            if (oldSuppliesOfEquipment == null)
                return;
            if (this.suppliesOfEquipment != null)
                if (this.suppliesOfEquipment.Contains(oldSuppliesOfEquipment))
                {
                    this.suppliesOfEquipment.Remove(oldSuppliesOfEquipment);
                    oldSuppliesOfEquipment.SetRoom((Room)null);
                }
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllSuppliesOfEquipment()
        {
            if (suppliesOfEquipment != null)
            {
                System.Collections.ArrayList tmpSuppliesOfEquipment = new System.Collections.ArrayList();
                foreach (SuppliesOfEquipment oldSuppliesOfEquipment in suppliesOfEquipment)
                    tmpSuppliesOfEquipment.Add(oldSuppliesOfEquipment);
                suppliesOfEquipment.Clear();
                foreach (SuppliesOfEquipment oldSuppliesOfEquipment in tmpSuppliesOfEquipment)
                    oldSuppliesOfEquipment.SetRoom((Room)null);
                tmpSuppliesOfEquipment.Clear();
            }
        }

        private int roomNumber;
        private int floor;
        private Boolean busy = false;

    }
}