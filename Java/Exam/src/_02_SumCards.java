import java.util.Scanner;


public class _02_SumCards {
	
	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		String[] cards = sc.nextLine().split("[CHDSP ]+");
		System.out.println();
		int allWidth = 0;
		if (cards.length==1) {
			System.out.println(WeightOfCard(cards[0]));
			return;
		}
		for (int i = 0; i < cards.length; i++) {
			if (i==0) {
				if (cards[i].equals(cards[i+1])) {
					allWidth += (WeightOfCard(cards[i])*2);
				} else {
					allWidth += WeightOfCard(cards[i]);
				}
			} else if (i == cards.length-1) {
				if (cards[i].equals(cards[i-1])) {
					allWidth += (WeightOfCard(cards[i])*2);
				} else {
					allWidth += WeightOfCard(cards[i]);
				}
			} else {
				if (cards[i].equals(cards[i-1])||cards[i].equals(cards[i+1])) {
					allWidth += (WeightOfCard(cards[i])*2);
				} else {
					allWidth += WeightOfCard(cards[i]);
				}
			}
		}
		System.out.println(allWidth);
	}
	private static int WeightOfCard (String card){
		int weight =0;
		switch (card) {
		case "2": weight =2; break;
		case "3": weight =3; break;
		case "4": weight =4; break;
		case "5": weight =5; break;
		case "6": weight =6; break;
		case "7": weight =7; break;
		case "8": weight =8; break;
		case "9": weight =9; break;
		case "10": weight =10; break;
		case "J": weight =12; break;
		case "Q": weight =13; break;
		case "K": weight =14; break;
		case "A": weight =15; break;
		}
		return weight;
	}

}
