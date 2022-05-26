using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern.Builder
{
    interface Userbuilder
    {
        UserAccount build();
        Userbuilder SetfirstName(string firstName);
        Userbuilder SetmiddleName(string middleName);
        Userbuilder SetlastName(string lastNAme);
        Userbuilder Setemail(string email);
        Userbuilder Settitle(string title);
        Userbuilder Setaddress(string address);
    }
}
