using System.Collections.Generic;

namespace BlazorDragAndDrop.Models
{
    public class SectionModel
    {
        public SectionType SectionType { get; set; }

        public string Title { get; set; }

        public List<SectionModel> Sections { get; set; } = new List<SectionModel>();

        public List<QuestionModel> Questions { get; set; } = new List<QuestionModel>();

        public int Position { get; set; }
    }
}