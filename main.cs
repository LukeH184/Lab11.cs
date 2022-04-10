using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter name of the first file: ");
    string f1 = Console.ReadLine();
    f1 = "file1.txt";
    Console.WriteLine("Enter name of the second file: ");
    string f2 = Console.ReadLine();
    f2 = "file2.txt";
    try {
      StreamReader sr1 = new StreamReader(f1);
      StreamReader sr2 = new StreamReader(f2);
      string txt1 = "";
      string txt2 = "";
      int line = 0;
      while (!sr1.EndOfStream || !sr2.EndOfStream){
        txt1 = sr1.ReadLine();
        txt2 = sr2.ReadLine();
        line++;
        if (txt1 != txt2){
          Console.WriteLine("Line: " + line);
          Console.WriteLine("< " + txt1);
          Console.WriteLine("> " + txt2);
          Console.WriteLine("");
        }
      
        
      }
    }
    catch (IOException ioex){
      Console.WriteLine("Error " + ioex);
    }
  }
}