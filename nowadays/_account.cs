using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nowadays
{
    internal class _account
    {
        List<string> username = new List<string>();
        List<string> password = new List<string>();

        public void setUsername(string var1)
        {
            username.Add(var1);
        }
       
        public void setPassword(string var2)
        {
            password.Add(var2);
        }
       
        
        public int login(string var1, string var2)
        {
            int index = username.IndexOf(var1);

            if (index >= 0)
            {

                if (password[index] == var2)
                {
                    MessageBox.Show("Login Succesfull");
                    return index;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    return -1; 
                }

            }
            else
            {
                MessageBox.Show("Register First!");
                return -1;
            }
            
        }
        

        



    }
}
