using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BowlingAlley
    {
        private int _number;
        private bool _operationalState;
        public int Number 
        { 
            get { return _number; }
            set { _number = value; }
        }

        public bool OperationalState
        {
            get { return _operationalState; }
            set { _operationalState = value; }
        }


    }
}
