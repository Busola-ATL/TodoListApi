﻿namespace TodoListModel;

public class Class1
{
     public class TodoItem
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Description { get; set; }
    }

}
