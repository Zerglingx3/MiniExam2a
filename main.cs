using System;

class MainClass {
  
  public static double CylinderVolume(double radius, double height){

    double volume = 3.14 * radius * radius * height;

    return volume;

  }
  
  
  
  
  
  public static void Main (string[] args) {
    
    Console.WriteLine ("What is the radius of the cylinder?");
    double radius = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine ("What is the height of the cylinder?");
    double height = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("The volume of the cylinder is " + CylinderVolume(radius, height) + " units.");

    
  }
}