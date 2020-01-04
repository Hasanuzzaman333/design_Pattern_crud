using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SampleData.SampleWebApiModels
{
    public class Ailment
    {
        [Key]
        public string Name { get; set; }
    }
}
