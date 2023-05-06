using DatagridSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DatagridSample.Utils
{
    public static class DummyProfessionalData
    {
        public static ObservableCollection<Professional> GetProfessionals()
        {
            var data = new ObservableCollection<Professional>();
            

            for (int i = 0; i < 10; i++)
            {
                var person = new Professional()
                {
                    Id = i+1,
                    Name = "Monkey",
                    Desigination = "Developer",
                    Domain = "Mobile",
                    Experience = "1"
                };
                data.Add(person);

            }
            return data;
        }
    }
}
