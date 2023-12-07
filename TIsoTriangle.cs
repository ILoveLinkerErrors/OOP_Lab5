class TIsoTriangle : TTRiangle {
    public double Base {
        get {
            return base.SideA;
        }
        set {
            try {
                base.SideA = value;    
            } catch (Exception e) {
                throw new ArgumentException($"{e} (TIsoTriangle Base property setter)");
            }
        }
    }

    public double Leg {
        get {
            return base.SideB;
        } set {
            base.SideB = value;
        }
    }

    public TIsoTriangle(double baseSide, double legSide) { 
        base.SideA = baseSide;
        base.SideB = legSide;   
    }

    public TIsoTriangle() {
        base.SideA = 1;
        base.SideB = 1;
    }

    public override double GetArea()
    {
        return Base * Math.Sqrt(4 * Leg * Leg - Base * Base ) / 4;
    }

    public override double GetPerimeter()
    {
        return 2 * Leg + Base;
    }
} 