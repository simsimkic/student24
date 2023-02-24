using Model.Employee;
using Service.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.UserController
{

    public class SecretaryController
    {
      
        public List<Secretary> GetAllSecretary()
        {
            List<Secretary> sekretari = new List<Secretary>();
            secretaryService = new SecretaryService();
            sekretari = secretaryService.GetAllSecretary();

            return sekretari;
        }

        public Secretary GetSecretary(String username)
        {
            // TODO: implement
            return null;
        }

        public Secretary RegisterSecretary(Secretary secretary)
        {
            secretaryService = new SecretaryService();
            return secretaryService.RegisterSecretary(secretary);

        }
        public SecretaryService secretaryService;
    }
}
