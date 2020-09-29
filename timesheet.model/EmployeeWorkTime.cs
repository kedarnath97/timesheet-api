using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace timesheet.model
{
    public class EmployeeWorkTime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EntryId { get; set; }
        [Required]
        public DateTime RecordDate { get; set; }
        [Required]
        public string EmployeeCode { get; set; }
        [Required]
        public int TaskId { get; set; }

        [DefaultValue(0)]
        public double TaskHours { get; set; }

        public string Comments { get; set; }
    }
}
