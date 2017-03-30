using System;

public partial class Calculate
{
	private double BMI(double height, double weight)
    {
        double BMI = weight / height / height;
        return BMI;
    }
}

