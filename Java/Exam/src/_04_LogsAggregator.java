import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.TreeSet;


public class _04_LogsAggregator {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		int n = Integer.parseInt(sc.nextLine());
		TreeMap<String, HashMap<Integer, TreeSet<String>>>  input= new TreeMap<>();
		for (int i = 0; i < n; i++) {
			ArrayList <String> ips = new ArrayList<>();
			String[] temp = sc.nextLine().split(" ");
			if (!input.containsKey(temp[1])) {
				input.put(temp[1], new HashMap(){{put(Integer.parseInt(temp[2]),new TreeSet<String>() {{
					add(temp[0]);
				}});}});
			} else if (input.containsKey(temp[1])) {
				int tempminses = 0;
				for (Integer s : input.get(temp[1]).keySet()) {
					tempminses = s;
				}
				int temp2 = tempminses +Integer.parseInt(temp[2]);
				input.get(temp[1]).put(temp2, input.get(temp[1]).remove(tempminses));
				input.get(temp[1]).get(temp2).add(temp[0]);
				
			} 
			
		}
		Iterator<String> keySetIterator = input.keySet().iterator();
		while(keySetIterator.hasNext()){
			  String key = keySetIterator.next();
			  System.out.println(key + ": " + input.get(key).toString().replace("{", "").replace("}", "").replace("=", " "));
			}
//		String out = input.toString().replace('{',' ').replace("}","");
//		System.out.println(out);

	}

}
//7
//192.168.0.11 peter 33
//10.10.17.33 alex 12
//10.10.17.35 peter 30
//10.10.17.34 peter 120
//10.10.17.34 peter 120
//212.50.118.81 alex 46
//212.50.118.81 alex 4
