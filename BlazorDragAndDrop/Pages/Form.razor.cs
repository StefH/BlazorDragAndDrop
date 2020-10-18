using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using BlazorDragAndDrop.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDragAndDrop.Pages
{
    public partial class Form : ComponentBase
    {
        public FormModel MyForm = new FormModel
        {
            Sections = new List<SectionModel>
            {
                new SectionModel
                {
                    Title ="first section",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Text = "q 1"
                        },
                        new QuestionModel
                        {
                            Text = "q 2"
                        }
                    }
                },
                new SectionModel
                {
                    Title ="second section with nested",
                    Sections = new List<SectionModel>
                    {
                        new SectionModel
                        {
                            Title = "nested first",
                            Questions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Text = "test abc"
                                }
                            }
                        }
                    }
                }
            },
        };

        private void AddSection()
        {
            var newSection = new SectionModel
            {
                Title = "section title...",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Text = "placeholder question..."
                    }
                }
            };

            MyForm.Sections.Add(newSection);
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(MyForm, new JsonSerializerOptions {  WriteIndented = true });
            Console.WriteLine(json);
        }

        public void ItemDropped(QuestionModel q)
        {
            Console.WriteLine("QuestionDropped = '{0}'", q.Text);

            StateHasChanged();
        }

        public void SectionDropped(SectionModel s)
        {
            Console.WriteLine("SectionDropped = '{0}'", s.Title);

            StateHasChanged();
        }
    }
}
