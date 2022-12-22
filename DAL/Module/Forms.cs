using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertJsonToForm.DAL.Module
{
    public class Forms
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string TexTarea { get; set; }
        public string Radio { get; set; }
        public string CheckBox { get; set; }
        public string DropdownList { get; set; }
        public string Toggle { get; set; }
        public string Range { get; set; }
    }
}
