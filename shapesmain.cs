namespace shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle = new circle();
            square square = new square();
            rectangle rectangle = new rectangle();
            triangle triangle = new triangle();         
            try
            {
            
            while (true)
                { 
                Console.Clear();
                Console.WriteLine("Meny\nQ - square\nW - rectangle\nE - circle\nR - triangle");
                ConsoleKey taken_key = Console.ReadKey().Key;              
                    switch (taken_key)
                    {
                    case ConsoleKey.Q:
                        Console.WriteLine();
                        Console.WriteLine("Enter side of square: ");
                        double square_a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Perimeter of square: "+ square.perimetr_square(square_a));
                        Console.WriteLine("Area of square: "+ square.area_square(square_a));
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine();
                        Console.WriteLine("Enter side 1 of rectangle");
                        double rectangle_a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side 2 of rectangle");
                        double rectangle_b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Perimetr of rectangle: " + rectangle.perimetr_rectangle(rectangle_a, rectangle_b));
                        Console.WriteLine("Area of rectangle: " + rectangle.area_rectangle(rectangle_a,rectangle_b));
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                            break;
                    case ConsoleKey.E:
                        Console.WriteLine();
                        Console.WriteLine("Enter radius of circle\n");
                        double radius_circle = double.Parse(Console.ReadLine());
                        Console.WriteLine("Perimentr of circle: " + circle.perimetr_circle(radius_circle));
                        Console.WriteLine("Area of circle: "+circle.area_circle(radius_circle));
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                            break;
                    case ConsoleKey.R:
                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine("Choose which triangle\n");
                        Console.WriteLine("A - common triangle\nS - rectangular triangle\nD - correct triangle");
                        ConsoleKey key_ = Console.ReadKey().Key;
                        switch(key_)
                        {
                            case ConsoleKey.A:
                                Console.WriteLine();
                                Console.WriteLine("Enter side 1 of triangle(base of triangle)");
                                double triangle_a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side 2 of triangle");
                                double triangle_b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side 3 of triangle");
                                double triangle_c = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter height of triangle");
                                double height_triangle = double.Parse(Console.ReadLine());
                                    if((Math.Pow(triangle_a,2) +Math.Pow(triangle_b,2) <= Math.Pow(triangle_c,2))||(Math.Pow(triangle_b,2)+Math.Pow(triangle_c, 2)) <=Math.Pow(triangle_a,2)||(Math.Pow(triangle_a, 2) + Math.Pow(triangle_c, 2) <=Math.Pow(triangle_b,2)))
                                    {
                                        Console.WriteLine("Triangle is not common");
                                        Console.WriteLine("Press any key to continue");
                                        Console.ReadKey();
                                        break;
                                    }
                                Console.WriteLine("Area of triangle: " +triangle.area_triangle_common(triangle_a, height_triangle));
                                Console.WriteLine("Perimetr of triangle: " +triangle.periment_triangle_common(triangle_a,triangle_b,triangle_c));
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                    break;
                            case ConsoleKey.S:
                                Console.WriteLine();
                                Console.WriteLine("Enter side 1 of triangle");
                                triangle_a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side 2 of triangle");
                                triangle_b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side 3 of triangle");
                                triangle_c = double.Parse(Console.ReadLine());
                                    if ((triangle_c > triangle_a) && (triangle_c > triangle_b))
                                    {
                                        if ((Math.Pow(triangle_a, 2) + Math.Pow(triangle_b, 2)) != Math.Pow(triangle_c, 2))
                                        {
                                            Console.WriteLine("Triangle is not rectangular");
                                            Console.WriteLine("Press any key to continue");
                                            Console.ReadKey();
                                            break;
                                        }
                                    }
                                    if ((triangle_b > triangle_a) && (triangle_b > triangle_c))
                                    {
                                        if ((Math.Pow(triangle_a, 2) + Math.Pow(triangle_c, 2)) != Math.Pow(triangle_b, 2)) 
                                        {
                                            Console.WriteLine("Triangle is not rectangular");
                                            Console.WriteLine("Press any key to continue");
                                            Console.ReadKey();
                                            break;
                                        }
                                    }
                                    if ((triangle_a > triangle_b) && (triangle_a > triangle_c))
                                    {
                                        if ((Math.Pow(triangle_b, 2) + Math.Pow(triangle_c, 2)) != Math.Pow(triangle_a, 2))
                                        {
                                            Console.WriteLine("Triangle is not rectangular");
                                            Console.WriteLine("Press any key to continue");
                                            Console.ReadKey();
                                            break;
                                        }
                                    }
                                    Console.WriteLine("Area of triangle: "+ triangle.area_triangle_rectangular(triangle_a,triangle_b));
                                    Console.WriteLine("Perimetr of circle: " + triangle.periment_triangle_common(triangle_a, triangle_b, triangle_c));
                                    Console.WriteLine("Press any key to continue");
                                    Console.ReadKey();
                                    break;
                            case ConsoleKey.D:
                                Console.WriteLine();
                                Console.WriteLine("Enter side 1 of triangle");
                                triangle_a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side 2 of triangle");
                                triangle_b = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side 3 of triangle");
                                triangle_c = double.Parse(Console.ReadLine());
                                    if((triangle_a != triangle_b)||(triangle_b!=triangle_c)||(triangle_a != triangle_c))
                                    {
                                        Console.WriteLine("Triangle is not correct");
                                        Console.WriteLine("Press any key to continue");
                                        Console.ReadKey();
                                        break;
                                    }
                                Console.WriteLine("Area of triangle: " + triangle.area_triangle_correct(triangle_a));
                                Console.WriteLine("Perimetr of circle: " + triangle.periment_triangle_common(triangle_a, triangle_b, triangle_c));
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error. Press any button to continue");
                Console.ReadKey();
            }
        }
    }
}