package asd20.com;

import java.util.*;

public class Prob02 {
	static void Problem02()
	{
		Scanner scanner = new Scanner(System.in);
		String test = scanner.nextLine();
		List<String> Hand = Arrays.asList(test.split(" "));
		int Red = 0;
		int Black = 0;
		int Hearts = 0;
		int Spades = 0;
		int Diamonds = 0;
		int Clubs = 0;
		int Two = 0;
		int Three = 0;
		int Four = 0;
		int Five = 0;
		int Six = 0;
		int Seven = 0;
		int Eight = 0;
		int Nine = 0;
		int Ten = 0;
		int Jack = 0;
		int Queen = 0;
		int King = 0;
		int Ace = 0;
		for (int i = 0; i < Hand.size(); i++)
		{
			String card = Hand.get(i);
			char temp = card.charAt(card.length()-1);
			if (temp == 'H'){
				Red++;
				Hearts++;
			}
			else if (temp == 'S') {
				Black++;
				Spades++;
			}
			else if (temp == 'D') {
				Red++;
				Diamonds++;
			}
			else if (temp == 'C') {
				Black++;
				Clubs++;
			}
			card = card.substring(0, card.length()-1);
			if (card.equals("A"))
				Ace++;
			else if (card.equals("J"))
				Jack++;
			else if (card.equals("Q"))
				Queen++;
			else if (card.equals("K"))
				King++;
			else if (card.equals("2"))
				Two++;
			else if (card.equals("3"))
				Three++;
			else if (card.equals("4"))
				Four++;
			else if (card.equals("5"))
				Five++;
			else if (card.equals("6"))
				Six++;
			else if (card.equals("7"))
				Seven++;
			else if (card.equals("8"))
				Eight++;
			else if (card.equals("9"))
				Nine++;
			else if (card.equals("10"))
				Ten++;
		}
		System.out.println("HAND " + Hand.size());
		System.out.println(Red + "-RED");
		System.out.println(Black + "-BLACK");
		System.out.println(Clubs + "-CLUBS");
		System.out.println(Diamonds + "-DIAMONDS");
		System.out.println(Hearts + "-HEARTS");
		System.out.println(Spades + "-SPADES");
		if (Two > 1)
			System.out.println(Two + "-2 cards");
		else if (Two == 1)
			System.out.println(Two + "-2 card");
		if (Three > 1)
			System.out.println(Three + "-3 cards");
		else if (Three == 1)
			System.out.println(Three + "-3 card");
		if (Four > 1)
			System.out.println(Four + "-4 cards");
		else if (Four == 1)
			System.out.println(Four + "-4 card");
		if (Five > 1)
			System.out.println(Five + "-5 cards");
		else if (Five == 1)
			System.out.println(Five + "-5 card");
		if (Six > 1)
			System.out.println(Six + "-6 cards");
		else if (Six == 1)
			System.out.println(Six + "-6 card");
		if (Seven > 1)
			System.out.println(Seven + "-7 cards");
		else if (Seven == 1)
			System.out.println(Seven + "-7 card");
		if (Eight > 1)
			System.out.println(Eight + "-8 cards");
		else if (Eight == 1)
			System.out.println(Eight + "-8 card");
		if (Nine > 1)
			System.out.println(Nine + "-9 cards");
		else if (Nine == 1)
			System.out.println(Nine + "-9 card");
		if (Ten > 1)
			System.out.println(Ten + "-10 cards");
		else if (Ten == 1)
			System.out.println(Ten + "-10 card");
		if (Jack > 1)
			System.out.println(Jack + "-Jacks");
		else if (Jack == 1)
			System.out.println(Jack + "-Jack");
		if (Queen > 1)
			System.out.println(Queen + "-Queens");
		else if (Queen == 1)
			System.out.println(Jack + "-Queen");
		if (King > 1)
			System.out.println(King + "-Kings");
		else if (King == 1)
			System.out.println(King + "-King");
		Collections.sort(Hand);
		for (int i = 0; i < Hand.size(); i++)
		{
			System.out.println(Hand.get(i));
		}
		scanner.close();
	}
}
