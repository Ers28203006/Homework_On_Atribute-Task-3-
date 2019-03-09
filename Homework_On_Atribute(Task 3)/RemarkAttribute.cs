using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_On_Atribute_Task_3_
{
    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public RemarkAttribute(string successfulComment, string unsuccessfulСomment)
        {
            Remark1= successfulComment;
            Remark2 = unsuccessfulСomment;
        }
    }
}
