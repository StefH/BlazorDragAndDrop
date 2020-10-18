using System.Collections.Generic;

namespace BlazorDragAndDrop.Models
{
    public class FormModel
    {
        public string Name { get; set; }

        public List<QuestionModel> Questions { get; set; } = new List<QuestionModel>();

        public List<SectionModel> Sections { get; set; } = new List<SectionModel>();
    }
}