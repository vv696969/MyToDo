﻿using MyToDo.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.Service
{
    public class ToDoService : BaseService<int, ToDoDto>, IToDoService
    {
        public ToDoService(HttpRestClient client ) : base(client, "ToDo" )
        {
        }
    }
}
