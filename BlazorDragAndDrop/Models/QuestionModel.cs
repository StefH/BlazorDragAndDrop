using BlazorDragAndDrop.Enums;

namespace BlazorDragAndDrop.Models
{
    public class QuestionModel
    {
        public string Text { get; set; }

        public int Position { get; set; }

        public QuestionType QuestionType { get; set; }

        public string Other { get; set; }
    }
}