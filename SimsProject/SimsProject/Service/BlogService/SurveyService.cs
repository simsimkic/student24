/***********************************************************************
 * Module:  SurveyService.cs
 * Purpose: Definition of the Class Model.User.SurveyService
 ***********************************************************************/

using Model.User;
using SimsProject.Repository.BlogRepository;
using System;
using System.Collections.Generic;

namespace Service.BlogService
{
   public class SurveyService
   {
      public void SendSurvey(Survey survey)
      {
         // TODO: implement
      }
      
      public Survey FillOutTheSurvey(Survey survey)
      {
         // TODO: implement
         return null;
      }
      
      public List<Survey> GetAllSurvey()
      {
         // TODO: implement
         return null;
      }
      
      public Survey GetSurvey(int id)
      {
         // TODO: implement
         return null;
      }
   
      public ISurveyRepository isurveyRepository;
   
   }
}