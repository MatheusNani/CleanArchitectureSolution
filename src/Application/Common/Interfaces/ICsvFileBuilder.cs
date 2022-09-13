﻿using CleanArchitectureSolution.Application.TodoLists.Queries.ExportTodos;

namespace CleanArchitectureSolution.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
