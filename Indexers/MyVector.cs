namespace Indexers
{
    public struct MyVector
    {

        public float this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return X;
                }
                else if (i == 1)
                {
                    return Y;
                }
                else
                {
                    throw new System.IndexOutOfRangeException("Must be 0 or 1!");
                }
            }

            set
            {
                if (i == 0)
                {
                    X = value;
                }
                else if (i == 1)
                {
                    Y = value;
                }
                else
                {
                    throw new System.IndexOutOfRangeException("Must be 0 or 1!");
                }
            }
        }


        public float  this [string idx]
        {
            get
            {
                if (idx == "x" || idx == "a"  || idx == "0")
                {
                    return X;
                }
                if (idx == "y" || idx == "b"  || idx == "1")
                {
                    return Y;
                }
                else
                {
                    throw new System.IndexOutOfRangeException("Must be X or Y!");
                }
            }

            set
            {
                if (idx == "X")
                {
                    X = value;
                }
                else if (idx == "Y")
                {
                    Y = value;
                }
                else
                {
                    throw new System.IndexOutOfRangeException("Must be X or Y!");
                }
            }
        }


        public float X { get; set; }
        public float Y { get; set; }
        public MyVector(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}