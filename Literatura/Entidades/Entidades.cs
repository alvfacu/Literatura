using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Entidades
    {
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
        
        /*private int _ID;*/
        private States _State;

       
        public Entidades()
        {
            this.State = States.New;
        }

        /*public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }*/

        public States State
        {
            get { return _State; }
            set { _State = value; }
        }
    }
}
