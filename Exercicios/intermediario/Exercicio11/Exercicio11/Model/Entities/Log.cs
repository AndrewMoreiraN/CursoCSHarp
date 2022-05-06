using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    internal class Log
    {
        public string Username { get; set; }
        public DateTime LogTime { get; set; }

        public Log(string name, DateTime logTime)
        {
            Username = name;
            LogTime = logTime;
        }

        public override bool Equals(object obj)
        {
            if (obj is Log)
            {
                Log other = obj as Log;
                return Username.Equals(other.Username);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
    }
}