import java.math.BigDecimal;
import java.util.Scanner;


public class _03_SimpleExpression {
	
	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		String[] input = sc.nextLine().split("[ ]+");
		String inputAsString = "";
		for (int i = 0; i < input.length; i++) {
			inputAsString+=input[i];
		}
		
		String[] digits = inputAsString.split("[+-]+");
		String[] operator = inputAsString.split("[0123456789.]+");
		BigDecimal output = new BigDecimal(digits[0]);
		for (int i = 0; i < operator.length-1; i++) {
			if (operator[i+1].equals("+")) {
				output = output.add(new BigDecimal(digits[i+1]));
			} else {
				output = output.subtract(new BigDecimal(digits[i+1]));
			}
				
			
		}
		System.out.println(output);
	}

}
