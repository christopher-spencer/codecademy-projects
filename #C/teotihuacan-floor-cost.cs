using System;

namespace ArchitectArithmetic {
  class Program {
    
    static double rectangleArea(double length, double width) {
      return length * width;
    }

    static double circleArea(double radius) {
      return Math.PI * Math.Pow(radius, 2);
    }

    static double triangleArea(double bottom, double height) {
      return 0.5 * bottom * height;
    }

    public static void Main(string[] args) {

      Console.WriteLine(rectangleArea(4, 5) );
      Console.WriteLine(circleArea(4) );
      Console.WriteLine(triangleArea(10, 9) );

      double teotihuacanRectangle = rectangleArea(1500,2500);
      double teotihuacanTriangle = triangleArea(750,500);
      double teotihuacanHalfCircle = circleArea(375) / 2;

      double teotihuacanArea = teotihuacanRectangle + teotihuacanTriangle + teotihuacanHalfCircle;

      double pesosFloorMaterialCost = 180;

      double totalCost = teotihuacanArea * pesosFloorMaterialCost;

      totalCost = Math.Round(totalCost, 2);

      Console.WriteLine($"The cost to redo the floor at Teotihuacan in Mexico City, Mexico would be {totalCost} pesos.");

    }
  }
}