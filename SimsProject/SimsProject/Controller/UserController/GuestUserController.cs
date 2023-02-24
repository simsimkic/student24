using Model.User;
using Service.UserService;

namespace Controller.UserController
{
    public class GuestUserController
    {
        public Patient RegisterGuestPatient(Patient guestPatient)
        { 
            guestPatientService = new GuestUserService();
            return guestPatientService.registerGuestPatient(guestPatient);
        }

        public GuestUserService guestPatientService;
    }
}
