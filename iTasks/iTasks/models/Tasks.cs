using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public Maneger IdManeger { get; set; }
        public Programmer IdProgrammer { get; set; }


        public int ExecutionOrder { get; set;}
        public string Description { get; set; }
        public DateTime EstimatedStartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public TaskType idTaskType { get; set; }

        public int StoryPoints { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public DateTime CreationDate { get; set;} = DateTime.Now;
        public CurrentStatus CurrentStatus {  get; set; }

        
        public Tasks()
        {
        }

        public override string ToString()
        {
            return $" [{ ExecutionOrder   }]  Descrição: { Description }" ;
        }

    }
}
