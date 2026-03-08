using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class UserService
{
    public List<User> GetAllUserse()
    {
        String getUsersSql = "Select * from Users";
        List<User> users = DbHelper.RunSelect<User>(getUsersSql);
        return users;
    }
}
