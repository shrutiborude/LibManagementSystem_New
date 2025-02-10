using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManagementSystem_Updated.Classes
{
    public class LoadDataIntoGrid
    {
       public static void LoadIntoGrid<T>(DataGridView gridView, DatabaseService<T> service) where T : class
       {
            if (gridView != null && service != null)
            {
                gridView.DataSource = service.GetAll().ToList();

            }
       }

        
    }
}
