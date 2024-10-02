using System;

// Create a Fraction class: Responsibility of this class is to hold fraction
public class Fraction
{
    // The class has two attributes for the top and bottom numbers which are private
    private int _top;
    private int _bottom;

    // Create a constructor that has no parameters that initializes the number to 1/1
    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    // Create a constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Create a constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Step 6: Create methods to return the representations:
    // 1. Create a method called GetFractionString that returns the fraction in the form 3/4.
    // 2. Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double) _top / (double) _bottom;
    }
}