using System;
using System.Collections.Generic;
using System.Text;

namespace task_8.Views
{
    public interface IModel
    {
        string firstPathText { get; set; }
        string secondPathText { get; set; }

        string modifiedText { get; set; }
    }
}
