using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    /// <summary>
    /// Compose objects into tree structures to represent part-whole hierarchies. 
    /// Composite lets clients treat individual objects and compositions of objects uniformly.
    /// </summary>
    /// 

    interface ITodoList
    {
        string GetHtml();
    }

    class Todo : ITodoList
    {
        private readonly string text;

        public Todo(string text)
        {
            this.text = text;
        }

        public string GetHtml()
        {
            return text;
        }
    }

    class Project : ITodoList
    {
        private readonly string title;
        private readonly List<ITodoList> todos;

        public Project(string title, List<ITodoList> todos)
        {
            this.title = title;
            this.todos = todos;
        }

        public string GetHtml()
        {
            string html = $"<h1>{title}</h1>";
            html += "<ul>";
            foreach (var item in todos)
            {
                html += "<li>";
                html += item.GetHtml();
                html += "</li>";
            }
            html +="</ul>";
            return html;
        }


        //client
        class TodoUser
        {
            void RenderTodo()
            {
                Project project = new Project("Main", new List<ITodoList>() {
                    new Todo("todo 1"),
                    new Project("Sub Project 1",
                        new List<ITodoList>() {
                         new Todo("todo 2-1")
                    })
                });
                project.GetHtml();
            }
          
        }
    }
}
