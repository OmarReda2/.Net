using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    // namespace =>
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum

    //Access modifier in name space =>
    // Public
    // Internal (defualt)

    public class TypeA
    {
        // class =>
        // 1. Attribute [MemberAccessException variables]
        // 2. Functions (constructor, Methode, Getter, Setter)
        // 3. properties
        // 4. Event

        // Access Modifiers =>
        // all the 6 access modifiers
        // defualt => private

        private int x; // Accessable inside the same class
        private protected int y; // Accessable inside the same class and the inherited class


    }

    public class TypeB: TypeA
    {
        TypeA T01 = new TypeA();
        // T01.y = 0 // must creat library class to have access modifier features (this is a console class)
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
