class TEqTriangle : TTRiangle {

    public double Side {
        get {
            return SideA;
        }
        set {
            SideA = value;
            SideB = value;
            SideC = value;
        }
    }

    public TEqTriangle() {
        base.isInitialized = false;
        Side = 1;
    }
    public TEqTriangle(double side) {
        base.isInitialized = false;
        Side = side;
    }

    public TEqTriangle(TEqTriangle copy) {
        base.isInitialized = false;
        Side = copy.Side;
    }

    public override double GetArea()
    {
        return 0.43301270189 * SideA;
    }

    public override double GetPerimeter()
    {
        return SideA * 3;
    }

    public override string ToString()
    {
        return $"Side = {Side}";
    }
}