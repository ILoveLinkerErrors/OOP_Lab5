class TTRiangle {
    private double sideA;
    private double sideB;
    private double sideC;

    private bool isInitialized = false;

    public static readonly double EPSILON = 1e-8;
    
    public double SideA
    {
        get {
            return sideA; 
        }
        set { 
            if (value < EPSILON) {
                throw new ArgumentException("triangle side <A> must be bigger than 0.");
            }
            if (isInitialized) {
                if (!IsValidTriangle(value, sideB, sideC)) {
                    throw new ArgumentException($"current lengths of sides <B>, <C> and {value} do not form a valid triangle.");
                }
            }
            sideA = value; 
        }
    }

    public double SideB
    {
        get { 
            return sideB; 
        }
        set {
            if (value < EPSILON) {
                throw new ArgumentException("triangle side <B> must be bigger than 0.");
            }
            if (isInitialized) {
                if (!IsValidTriangle(SideA, value, sideC)) {
                    throw new ArgumentException($"current lengths of sides <A>, <C> and {value} do not form a valid triangle.");
                }
            }
            sideB = value; 
        }
    }

    public double SideC
    {
        get { 
            return sideC; 
        }
        set { 
            if (value < EPSILON) {
                throw new ArgumentException("triangle side <B> must be bigger than 0.");
            }
            if (isInitialized) {
                if (!IsValidTriangle(SideA, SideB, value)) {
                    throw new ArgumentException($"current lengths of sides <A>, <C> and {value} do not form a valid triangle.");
                }
            }
            sideC = value; 
        }
    }

    private static bool IsValidTriangle(double a, double b, double c) {
        if (a < EPSILON || b < EPSILON || c < EPSILON) {
            return false;
        }
        return a + b - c > EPSILON && a + c - b > EPSILON && b + c - a > EPSILON;
    }

                
    public TTRiangle(double A, double B, double C) {  
        if (!IsValidTriangle(A, B, C)) {
            throw new ArgumentException($"Fatal Error: sides {A}, {B}, {C} do not form a valid triangle");
        }   
        sideA = A;
        sideB = B;
        sideC = C;
        isInitialized = true;
    }

    public TTRiangle() {
        SideA = 1;
        SideB = 1;
        SideC = 1;
        isInitialized = true;
    }

    public TTRiangle(TTRiangle copy) {
        SideA = copy.sideA;
        SideB = copy.sideB;
        SideC = copy.SideC;
        isInitialized = true;
    }

    public virtual double GetPerimeter() {
        return SideA + SideB + SideC;
    }

    public virtual double GetArea() {
        double halfPerim = 0.5 * GetPerimeter();
        return Math.Sqrt(halfPerim * (halfPerim - SideA) * (halfPerim - SideB) * (halfPerim - SideC));
    }
}