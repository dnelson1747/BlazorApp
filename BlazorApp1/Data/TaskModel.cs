using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TaskModel
    {
        public string Task { get; set; }
        //public bool IsStarted Task { get; set; }
        //public bool InProgress { get; set; }
        
        public bool IsComplete { get; set; }
    }
}
