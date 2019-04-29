package asd20.com;

import java.util.Scanner;

public class Prob01 {
	static void Problem01()
	{
		Scanner scanner = new Scanner(System.in);
		String test = scanner.nextLine();
		int variable = Integer.parseInt(test);
		if (variable % 7 != 0 && variable % 3 != 0)
			System.out.print(variable);
		if (variable % 3 == 0)
			System.out.print("CODE");
		if (variable % 7 == 0)
			System.out.print("QUEST");
		System.out.println();
		scanner.close();
	}
}
