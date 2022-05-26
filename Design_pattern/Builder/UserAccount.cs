using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Builder
{
    class UserAccount
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string email;
        public string title;
        public string address;
       public static  Userbuilder getUserAccount()
        {
            return new UserBuilderImp();
        }
      
    }

   
}
