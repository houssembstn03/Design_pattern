using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Builder
{
    class UserBuilderImp : Userbuilder
    {
        UserAccount userAccount;
        public UserBuilderImp()
        {
            userAccount = new UserAccount();
        }

        public UserAccount build()
        {
            if(userAccount.address ==null)
            {

                throw new Exception();
            }
           return userAccount;
        }

        public Userbuilder Setaddress(string address)
        {
            userAccount.address = address;
           return this;
        }

        public Userbuilder Setemail(string email)
        {
            userAccount.email=email;
            return this;
        }

        public Userbuilder SetfirstName(string firstName)
        {
            userAccount.firstName=firstName;
            return this;
        }

        public Userbuilder SetlastName(string lastNAme)
        {
            userAccount.lastName = lastNAme;
            return this;
        }

        public Userbuilder SetmiddleName(string middleName)
        {
            userAccount.lastName=middleName;
            return this;
        }

        public Userbuilder Settitle(string title)
        {
            userAccount.title=title;    
            return this;
        }
    }
}
