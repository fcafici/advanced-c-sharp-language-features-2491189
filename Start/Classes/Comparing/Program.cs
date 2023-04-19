// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Comparing objects for equality

// Declare some Point2D instances
Point2D p1 = new Point2D() {X = 10, Y = 20};
Point2D p2 = new Point2D() {X = 10, Y = 20};
Point2D? p3 = null, p4 = null;

// Test for equality
Console.WriteLine($"{p1.Equals(p2)}");
Console.WriteLine($"{p1 == p2}");
Console.WriteLine($"{p1 != p2}");
Console.WriteLine($"{p3 == p4}");

// TODO: The IEquatable interface gives us a type-specific Equals() method
public class Point2D : IEquatable<Point2D> {
    public int X;
    public int Y;

    // TODO: Override the methods needed to define value equality
    public override bool Equals(object? obj) => Equals(obj as Point2D);
    public bool Equals(Point2D? p) => p != null && (X == p.X && Y == p.Y);

    public override int GetHashCode() => (X,Y).GetHashCode();

    // TODO: Override the == and != operators as well

    // este yo preferiría dejarlo como está para que compare la referencia. Para comparar por valor, uso Equals.
    public static bool operator == (Point2D? p1, Point2D? p2)
    {
        if (p1 is null)
        {
            if (p2 is null)
                return true;
            return false;
        }
        return p1.Equals(p2);
    }
    
    public static bool operator != (Point2D? p1, Point2D? p2) => !(p1 == p2);
}
