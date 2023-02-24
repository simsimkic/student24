/***********************************************************************
 * Module:  SurveyRepository.cs
 * Purpose: Definition of the Class Service.BlogService.SurveyRepository
 ***********************************************************************/

using Model.User;
using SimsProject.Repository.BlogRepository;
using SimsProject.Repository.GenericRepository;
using System;
using System.Collections.Generic;

namespace Repository.BlogRepository
{
   public class SurveyRepository : GenericRepository<Survey>, ISurveyRepository
    {
      public SurveyRepository(String filePath) : base(filePath){}
       
      public Survey GetSurvey(int id)
      {
         // TODO: implement
         return null;
      }
   
      private String path;
   
   }
}