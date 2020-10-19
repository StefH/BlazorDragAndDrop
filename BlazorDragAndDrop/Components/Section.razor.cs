using System.Collections.Generic;
using BlazorDragAndDrop.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDragAndDrop.Components
{
    public partial class Section : ComponentBase
    {
        [Parameter]
        public SectionModel Model { get; set; }

        [Parameter]
        public EventCallback<SectionModel> OnRemoveClick { get; set; }

        private void AddSection()
        {
            var newSection = new SectionModel
            {
                Title = "section title...",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Text = "place holder question 1..."
                    }
                }
            };

            Model.Sections.Add(newSection);
        }

        private void AddQuestion()
        {
            var newQuestion = new QuestionModel
            {
                Text = "please ask your question..."
            };

            Model.Questions.Add(newQuestion);
        }
    }
}