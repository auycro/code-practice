using System;
using System.Collections.Generic;
using System.IO;
class Solution {

static void displayPathtoPrincess(int n, String [] grid){
    int x1,x2,y1,y2;
    x1 = x2 = y1 = y2 = -1;
    int repeater = 0;

    for(int i=0;i<n;i++){
        var line = grid[i];
        if(line.Contains("m")){
            y1 = i;
            x1= line.IndexOf('m');
        }
        
        if(line.Contains("p")){
            y2 = i;
            x2 = line.IndexOf('p');
        }
    }
    
    //Console.WriteLine($"{x1},{y1}");
    //Console.WriteLine($"{x2},{y2}");

    int vertical = y2 - y1;
    repeater = Math.Abs(vertical);
    if (vertical < 0){
      int i=0;
      while(i < repeater){
        Console.WriteLine("UP");
        i++;
      }
    } else {
      int i=0;
      while(i < repeater){
        Console.WriteLine("DOWN");
        i++;
      }
    }

    int horizontal = x2 - x1;
    repeater = Math.Abs(horizontal);
    if (horizontal > 0){
      int i=0;
      while(i < repeater){
        Console.WriteLine("RIGHT");
        i++;
      }
    } else {
      int i=0;
      while(i < repeater){
        Console.WriteLine("LEFT");
        i++;
      }
    }
  }

static void Main(String[] args) {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
     }
}