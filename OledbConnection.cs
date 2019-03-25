using System;

namespace TurkceIngProje
{
    internal class OledbConnection  
    {
        private string connectionString;

        public OledbConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}