class TEqTriangle : TTRiangle {

    public double Side {
        get {
            return base.SideA;
        }
        set {
            base.SideA = value;
        }
    }
    public TEqTriangle(double side) {
        base.SideA = side;
    }

    public override double GetArea()
    {
        return 0.43301270189 * base.SideA;
    }

    public override double GetPerimeter()
    {
        return base.SideA * 3;
    }
}