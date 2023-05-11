namespace Access_modifier_part2
{
    public class TypeA
    {
        private int x; // x accessable only in he same class
        private protected int y; // y accessable only in the same class and the class and inherited class in the same namesape 
        protected int z; //  y accessable only in the same class and the class and inherited class 
        internal int w; //w accessable in the same namespace
        protected internal int m; // private protected  + inherited classes
        public int a;





    }
}