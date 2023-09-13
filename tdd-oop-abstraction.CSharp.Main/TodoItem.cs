using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class TodoItem {
        private string _status;
        private string _detail;
        private string _title;
        private DateTime _created;
        public TodoItem()
        {
            _created = DateTime.Now;
        }
        public string Title { get => _title; set => _title = value; }
        public string Detail { get => _detail; set => _detail = value; }
        public string Status { get => _status; set => _status = value; }

        public TodoItem(string title, string detail, string status) 
        {
            this._title = title;
            this._detail = detail;
            this._status = status;
        }

      
    }
}
