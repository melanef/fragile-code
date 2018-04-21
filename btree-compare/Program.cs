using System;

namespace fragile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running task 1 - compare bTrees.");
            var comparer = new BTNComparer();
            comparer.run();

            Console.ReadLine();
        }

    }

    class BTN
    {
        public int val;
        public BTN left;
        public BTN right;
    }

    class BTNComparer
    {
        public void run()
        {
            BTN a = new BTN
            {
                val = 1,
                left = new BTN
                {
                    val = 2
                },
                right = new BTN
                {
                    val = 3,
                    left = new BTN
                    {
                        val = 4
                    },
                    right = new BTN
                    {
                        val = 5
                    }
                }
            };

            BTN b = new BTN
            {
                val = 1,
                left = new BTN
                {
                    val = 2,
                    left = new BTN
                    {
                        val = 4
                    },
                    right = new BTN
                    {
                        val = 5
                    }
                },
                right = new BTN
                {
                    val = 3
                }
            };

            BTN c = new BTN
            {
                val = 1,
                left = new BTN
                {
                    val = 2
                },
                right = new BTN
                {
                    val = 3,
                    left = new BTN
                    {
                        val = 4
                    },
                    right = new BTN
                    {
                        val = 5
                    }
                }
            };

            BTN d = new BTN
            {
                val = 1,
                left = new BTN
                {
                    val = 2,
                    left = new BTN
                    {
                        val = 4
                    },
                    right = new BTN
                    {
                        val = 5
                    }
                },
                right = new BTN
                {
                    val = 3
                }
            };

            Console.WriteLine("Is a equal to b? {0}", BTreesAreEquals(a, b));
            Console.WriteLine("Is a equal to c? {0}", BTreesAreEquals(a, c));
            Console.WriteLine("Is a equal to d? {0}", BTreesAreEquals(a, d));
            Console.WriteLine("Is b equal to c? {0}", BTreesAreEquals(b, c));
            Console.WriteLine("Is b equal to d? {0}", BTreesAreEquals(b, d));
        }

        bool BTreesAreEquals(BTN a, BTN b)
        {
            if (a.val != b.val) {
                return false;
            }
            
            if (
                 (a.left != NULL && b.left == NULL)
              || (a.left == NULL && b.left != NULL)
              || (a.right != NULL && b.right == NULL)
              || (a.right == NULL && b.right != NULL)
            ) {
                return false;
            }
            
            if (a.left == NULL && b.left == NULL && a.right == NULL && b.right == NULL) {
                return true;
            }
            
            return BTreesAreEquals(a.left, b.left) && BTreesAreEquals(a.right, b.right); 
        }
    }   

}
