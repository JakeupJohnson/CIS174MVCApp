using CIS174MVCApp.Shared.Orchestrators.Interfaces;
using CIS174MVCApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174MVCApp.Shared.Orchestrators
{
    public class ProfileOrchestrator : IProfileOrchestrator
    {
        public List<StudentViewModel> GetAllStudents()
        {
            //normally would go to the database here
            var students = new List<StudentViewModel>
            {//this is object initialization in C#
                new StudentViewModel
                {
                    /*This information corresponds with StudentViewModel.cs - appears to be instantiating an object of StudentViewModel class*/
                    //Capacity = 30,
                    //CourseName = "Advanced C#",
                    //CourseNumber = 174,
                    //Department = "CIS"
                },

                new StudentViewModel
                {
                    /*This information corresponds with StudentViewModel.cs - appears to be instantiating an object of StudentViewModel class*/
                    //Capacity = 30,
                    //CourseName = "Intro to Game Design",
                    //CourseNumber = 140,
                    //Department = "CIS"
                }
            };

            return students;
        }
    }
}
