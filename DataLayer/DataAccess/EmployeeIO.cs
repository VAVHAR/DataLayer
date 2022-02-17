using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DataLayer.Business;

namespace DataLayer.DataAccess
{
    public static class EmployeeIO
    {
        const string dir = @"";

        const string filepath = dir + "employee.dat";

        public static void SaveRecord(Employee emp)
        {
            StreamWriter sw = new StreamWriter(filepath, true);
            sw.WriteLine(emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName);
            MessageBox.Show("Data Successfully Saved");
            sw.Close();
        }

        public static Employee SearchRecord(int id)
        {
            Employee emp = new Employee();

            if (File.Exists(filepath))
            {
                StreamReader sr = new StreamReader(filepath);
                string line = String.Empty;
                bool found = false;

                while (line != null)
                {
                    line = sr.ReadLine();
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) == id)
                    {
                        emp.EmployeeId = Convert.ToInt32(fields[0]);
                        emp.FirstName = fields[1];
                        emp.LastName = fields[2];

                        found = true;
                        break;
                    }
                    line = sr.ReadLine();

                }
                sr.Close();

                if (!found)
                {
                    emp = null;
                }
            }
            else
            {
                MessageBox.Show("Data not found");

            }
            return emp;
        }

    }
}
