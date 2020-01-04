using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SampleData.SampleWebApiModels
{
    public class Medication
    {
        [Key]
        public string Name { get; set; }
        public string Doses { get; set; }
    }
}
