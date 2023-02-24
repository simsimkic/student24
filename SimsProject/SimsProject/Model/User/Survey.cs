/***********************************************************************
 * Module:  Ankete.cs
 * Purpose: Definition of the Class Pacijent.Ankete
 ***********************************************************************/

using SimsProject.Model.Entity;
using System;

namespace Model.User
{
   public class Survey:Entity
   {
      public Patient patient;
      public System.Collections.ArrayList question;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetQuestion()
      {
         if (question == null)
            question = new System.Collections.ArrayList();
         return question;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetQuestion(System.Collections.ArrayList newQuestion)
      {
         RemoveAllQuestion();
         foreach (Question oQuestion in newQuestion)
            AddQuestion(oQuestion);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddQuestion(Question newQuestion)
      {
         if (newQuestion == null)
            return;
         if (this.question == null)
            this.question = new System.Collections.ArrayList();
         if (!this.question.Contains(newQuestion))
            this.question.Add(newQuestion);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveQuestion(Question oldQuestion)
      {
         if (oldQuestion == null)
            return;
         if (this.question != null)
            if (this.question.Contains(oldQuestion))
               this.question.Remove(oldQuestion);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllQuestion()
      {
         if (question != null)
            question.Clear();
      }
   
      private String title;
      private int id;
   
   }
}