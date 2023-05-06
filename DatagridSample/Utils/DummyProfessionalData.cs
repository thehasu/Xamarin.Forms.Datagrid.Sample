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
            var person = new Professional()
            {
                Name = "Monkey",
                Desigination = "Developer",
                Domain = "Mobile",
                Experience = "1"
            };

            for (int i = 0; i < 10; i++)
            {
                person.Id = i + 1;
                data.Add(person);

            }
            return data;
        }
    }
}
