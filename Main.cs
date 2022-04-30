using System;
using System.Text;

class DrugCalculator {
	public static Action<string> cw = Console.WriteLine;
	public static void Help(){
		cw("Argument 0 is drug. Argument 1 is method. Argument 2 is price/amount.");
		cw("-------------");
		cw("Drugs Available:");
		cw("0 - Cocaine");
		cw("1 - Weed");
		cw("2 - Meth");
		cw("3 - Crystal Meth");
		cw("4 - Black Tar Heroin");
		cw("5 - Oxycodone");
		cw("6 - Fentanyl");
		cw("7 - Codeine");
		cw("8 - LSD");
		cw("9 - Opium");
		cw("10 - MDMA");
		cw("11 - Ketamine");
		cw("-------------");
		cw("Methods Available:");
		cw("0 - Price To Amount");
		cw("1 - Amount To Price");
		cw("------------");
		cw("Price Format ($): 400");
		cw("Amount Format (Grams): 50");
		System.Environment.Exit(1);
	}

	static void Main(string[] args){
		if (args.Length <= 2){
			Help();
		} else if (args[0] == "help"){
			Help();
		}

		int drug = int.Parse(args[0]);
		int method = int.Parse(args[1]);
		var valid = decimal.TryParse(args[2], out decimal amount);
		
		if (drug + 1 > ppg.Length || drug < 0 || !valid){
			Help();
		}

		if (method == 0){
			cw($"Total grams: {Math.Round(amount / ppg[drug], 4)}");
		} else if (method == 1){
			cw($"Total price: {Math.Round(amount * ppg[drug], 2)}");
		} else {
			Help();
		}
	}

	public static int[] ppg = {
		60,
		15,
		40,
		80,
		100,
		50,
		150,
		89,
		2000,
		16,
		150,
		20		
	};
}
