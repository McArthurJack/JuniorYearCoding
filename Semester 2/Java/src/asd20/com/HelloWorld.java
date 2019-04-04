package asd20.com;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class HelloWorld {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Problem01();
	}
	
	static int Factorial(int i) {
		if (i == 1)
		{
			i = 1;
			return i;
		}
		else
		{
			int temp = i - 1;
			temp = i * Factorial(temp);
			return temp;
		}
	}
	
	static void Problem01()
	{
		String absolutePath = "Inputs\\Prob01.in.txt";
		try(BufferedReader bufferedReader = new BufferedReader(new FileReader(absolutePath))){
			int Count = Integer.parseInt(bufferedReader.readLine());
			for (int i = 0; i < Count; i++)
			{
				int test = Integer.parseInt(bufferedReader.readLine());
				if (test >= 70)
					System.out.println("Passed");
				else
					System.out.println("Failed");
			}
		} catch (FileNotFoundException e){
			// exception handling
		} catch (IOException e) {
			// exception handling
		}
	}
	
	static void Problem02()
	{
		String absolutePath = "Inputs\\Prob02.in.txt";
		try(BufferedReader bufferedReader = new BufferedReader(new FileReader(absolutePath))){
			int Count = Integer.parseInt(bufferedReader.readLine());
			for (int i = 0; i < Count; i++)
			{
				String line = bufferedReader.readLine();
				int Value = Integer.parseInt(String.valueOf(line.charAt(line.length()-1)));
				line = line.substring(0, line.length()-2);
				line = line.substring(0, Value) + line.substring(Value + 1);
				System.out.println(line);
			}
			
		} catch (FileNotFoundException e){
			// exception handling
		} catch (IOException e) {
			// exception handling
		}
	}

}
