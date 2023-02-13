using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    public class Node
    {
        public dynamic? Value { get; set; }
        private Node Next { get; set; }

        public Node(dynamic value) { 
            Value = value;
            Next = this;
        }

        public override string ToString()
        {
            if(Value != null) return Value.ToString();
            else return string.Empty;
        }

        public void Append(dynamic value)
        {
            if (!this.Exists(value))
            {
                Node Cursor = this;
                while (Cursor.Next != this) Cursor = Cursor.Next;
                Cursor.Next = new Node(value);
                Cursor.Next.Next = this;
            }
            else throw new Exception("Value already exists in list");
        }

        public void Clear()
        {
            Node temp_1 = this;
            Node temp_2 = this.Next;
            while(temp_1 != temp_2)
            {
                temp_1.Next = temp_1;
                temp_1 = temp_2;
                temp_2 = temp_2.Next;
            }
        }

        public bool Exists(dynamic value)
        {
            Node cursor = this;
            do
            {
                if(cursor.Value == value) return true;
                cursor = cursor.Next;
            } while (cursor.Next != this);
            return false;
        }



    }
}
