using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    struct ObjectTask
    {

        object obj;

        void constructor()
        {
            obj = new object();
        }

        void assign()
        {
            obj = new List<object>();
        }

        void toSTring()
        {
            obj = new object();
            String str = obj.ToString();
        }

        void getType()
        {
            obj = new object();
            Type type = obj.GetType();
        }

        void getHashCode()
        {
            obj = new object();
            int hash = obj.GetHashCode();
        }

        void equals()
        {
            obj = new object();
            bool equals = obj.Equals(new object());
        }

        void referenceEquals()
        {
            bool referenceEquals = object.ReferenceEquals(new object(), new object());
        }

        public class MyObject {

            public override string ToString()
            {
                return "im a little object";
            }

            public override int GetHashCode()
            {
                return 0;
            }

            public override bool Equals(object obj)
            {
                return false;
            }

            public new Type GetType()
            {
                return new object().GetType();
            }

        }

    }
}
