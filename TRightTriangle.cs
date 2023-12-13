class TRightTriangle : TTRiangle {

    public double CatOne {
        get {
            return SideA;
        } 
        set {
            SideA = value;
            setHypo();
        }
    }

    public double CatTwo {
        get {
            return SideB;
        }
        set {
            SideB = value;
            setHypo();
        }
    }

    public double Hypo {
        get {
            return SideC;
        }
    }   

    private void setHypo() {
        SideC = Math.Sqrt(CatOne*CatOne+CatTwo*CatTwo);
    }

    public TRightTriangle(double cat1, double cat2) {  
        base.isInitialized = false;
        CatOne = cat1;
        CatTwo = cat2;
    }

    public TRightTriangle() {
        base.isInitialized = false;
        CatOne = 1;
        CatTwo = 1;
    }

    public TRightTriangle(TRightTriangle copy) {
        base.isInitialized = false;
        CatOne = copy.CatOne;
        CatTwo = copy.CatTwo;
    }
 
    public override double GetPerimeter()
    {
        return CatOne + CatTwo + Hypo;
    }

    public override double GetArea() {
        return CatOne * CatTwo * 0.5;
    }

    public override string ToString()
    {
        return $"Cathetus 1 = {CatOne}\nCathetus 2 = {CatTwo}\nHypothenuse = {Hypo}";
    }
}