using System; 
using System.IO; 

class Program { 
	static void Main(string[] args) 
	{ 
		// Mətn faylının linkini yadda saxlayırıq 
		string file = @"M:\Documents\Textfile.txt"; 

		// Bütün faylı bir anda oxumaq üçün
		if (File.Exists(file)) { 
			string str = File.ReadAllText(file); 
			Console.WriteLine(str); 
		} 
		Console.WriteLine(); 

		// Faylı sətir-sətir oxumaq üçün
		if (File.Exists(file)) { 
			// Hər sətri bir array-də saxlayırıq
			string[] lines = File.ReadAllLines(file); 

			foreach(string ln in lines) 
				Console.WriteLine(ln); 
		} 
		Console.WriteLine(); 

		// StreamReader ilə faylı oxumaq
		if (File.Exists(file)) { 
			// Faylı sətir-sətir oxuyur 
			StreamReader Textfile = new StreamReader(file); 
			string line; 

			while ((line = Textfile.ReadLine()) != null) { 
				Console.WriteLine(line); 
			} 

			Textfile.Close(); 

			Console.ReadKey(); 
		} 
		Console.WriteLine(); 




                // Mətn faylının linkini dəyişəndə saxlayırıq
		string file = @"C:\Documents\Textfile.txt"; 

		// Mətnin hamsını fayla yazmaq
		string text = "Lorem ipsum"; 
		File.WriteAllText(file, text); 

		// Faylın indiki məzmunu oxunur 
		Console.WriteLine(File.ReadAllText(file)); 
		Console.WriteLine(); 

		// Mətni sətir-sətir yazmaq
		string[] textLines1 = { "First line", "Second line", "Third line" }; 

		File.WriteAllLines(file, textLines1); 

		// Mətn faylının indiki məzmunu oxumaq
		Console.WriteLine(File.ReadAllText(file)); 

		// StreamWriter ilə fayla sətir-sətir yazmaq 
		string[] textLines2 = { "New first line",  "New second line" }; 

		using(StreamWriter writer = new StreamWriter(file)) 
		{ 
			foreach(string ln in textLines2) 
			{ 
				writer.WriteLine(ln); 
			} 
		} 
		// Faylın indiki məzmununu oxumaq 
		Console.WriteLine(File.ReadAllText(file)); 

		Console.ReadKey(); 



		string file = @"C:\Documents\Textfile.txt"; 

		// Fayla bütün mətni yazmaq üçün
		string text1 = "This is some text."; 
		File.WriteAllText(file, text1); 

		// Fayla mətn əlavə etmək üçün 
		string text2 = "This is text to be appended"; 
		File.AppendAllText(file, text2); 

		// Faylın indiki məzmunu oxumaq üçün
		Console.WriteLine(File.ReadAllText(file)); 
		Console.ReadKey(); 
    
	} 
}
