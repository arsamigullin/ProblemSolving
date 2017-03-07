namespace Algorithms.Trees
{
    public class TreeFactory
    {
                    //                 D
                    //              /    \
                    //            B        E
                    //          /   \       
                    //        A       C
        public static BinaryNode<int> GetBinaryTreeWithHeight3()
        {
            BinaryNode<int> Droot = new BinaryNode<int>(1);
            BinaryNode<int> B = new BinaryNode<int>(2);
            BinaryNode<int> A = new BinaryNode<int>(3);
            BinaryNode<int> C = new BinaryNode<int>(4);
            BinaryNode<int> E = new BinaryNode<int>(5);
            Droot.LeftNode = B;
            Droot.RightNode = E;
            B.LeftNode = A;
            B.RightNode = C;
            Droot.Value = 4;
            B.Value = 3;
            A.Value = 1;
            C.Value = 2;
            E.Value = 5;


            return Droot;
        }
    }
}
