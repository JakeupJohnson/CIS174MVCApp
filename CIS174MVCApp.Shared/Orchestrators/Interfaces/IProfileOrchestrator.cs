using CIS174MVCApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174MVCApp.Shared.Orchestrators.Interfaces
{
    interface IProfileOrchestrator
    {
        List<StudentViewModel> GetAllStudents();
    }
}
