class TIsoTriangle : TTRiangle {
    public double Base {
        get {
            return SideA;
        }
        set {
            try {
                SideA = value;    
            } catch (Exception e) {
                throw new ArgumentException($"{e} (TIsoTriangle Base property setter)");
            }
        }
    }

    public double Leg {
        get {
            return SideB;
        } set {
            SideB = value;
            SideC = value;
        }
    }

    public TIsoTriangle(double baseSide, double legSide) { 
        base.isInitialized = false;
        Base = baseSide;
        Leg = legSide;   
    }

    public TIsoTriangle() {
        base.isInitialized = false;
        Base = 1;
        Leg = 1;
    }

    public TIsoTriangle(TIsoTriangle copy) {
        base.isInitialized = false;
        Base = copy.Base;
        Leg = copy.Leg;
    }
 
    public override double GetArea()
    {
        return Base * Math.Sqrt(4 * Leg * Leg - Base * Base ) / 4;
    }

    public override double GetPerimeter()
    {
        return 2 * Leg + Base;
    }


    public override string ToString()
    {
        return $"Base = {Base}\nLeg = {Leg}";
    }
} 