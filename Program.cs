using System;

namespace Baum {
    class Weihnachtsbaum {
        static void Main(string[] args) {

            bool run = true;
            Console.Clear();

            while(run) {
	                Console.ForegroundColor = ConsoleColor.White;
	                Console.WriteLine("--- Weihnachtsbaum ---\n");

	                Console.Write("Welche Variante soll gezeichnet werden? <1-5>: ");
	                int input_variant = Convert.ToInt32(Console.ReadLine());

	                if (input_variant < 1 || input_variant > 5) {
	                	Console.Clear();
		                Console.WriteLine("\nUngueltige Eingabe!\n");
		                continue;
	                }

	                Console.WriteLine("\n- Variante " + input_variant + " -\n");

	                Console.Write("Hoehe des Baumes eingeben <5-40>: ");
	                int input_height = Convert.ToInt32(Console.ReadLine());
	                Console.WriteLine("");

	                if (input_height < 5 || input_height > 40) {
		                Console.Clear();
		                Console.WriteLine("\nUngueltige Eingabe!\n");
		                continue;
	                }

					switch (input_variant) {
					    case 1:
							for (int i1 = 0; i1 < input_height; i1++) {
							    Console.WriteLine("X");
							}
						break;
						case 2:
						    int amount1 = 1;
							for (int i2 = 0; i2 < input_height; i2++) {
							    for (int i3 = 0; i3 < amount1; i3++) {
									Console.Write("X");
								}
								amount1++;
								Console.WriteLine("");
							}
							break;
						case 3:
						    int amount2 = 1;
							for (int i4 = 0; i4 < input_height; i4++) {
							    for (int i5 = 0; i5 < (input_height - (i4 + 1)); i5++) {
									Console.Write(" ");
								}
								for (int i6 = 0; i6 < (amount2 * 2 - 1); i6++) {
								    Console.Write("X");
								}
								amount2++;
								Console.WriteLine("");
							}
							break;
						case 4:
						    int amount3 = 1;
							for (int i7 = 0; i7 < input_height; i7++) {
							    for (int i8 = 0; i8 < (input_height - (i7 + 1)); i8++) {
									Console.Write(" ");
								}
								for (int i9 = 0; i9 < (amount3 * 2 - 1); i9++) {
								    Console.Write("X");
								}
								amount3++;
								Console.WriteLine("");
							}
							for (int i10 = 0; i10 < 2; i10++) {
							    for (int i11 = 0; i11 < (input_height - 1); i11++) {
									Console.Write(" ");
								}
								Console.WriteLine("H");
							}
							break;
						case 5:
						    Random r = new Random();
							int int_random1 = r.Next(0, 11);
							int int_random2 = r.Next(0, 21);
							int amount4 = 1;
							int cell_iteration = 0;
							int cell_count = 2;
							Console.ForegroundColor = ConsoleColor.Green;
							for (int i12 = 0; i12 < input_height; i12++) {
							    for (int i13 = 0; i13 < (input_height - amount4); i13++) {
							        Console.Write(" ");
								}
								for (int i14 = 0; i14 < (amount4 * 2 - 1); i14++) {
								    if (int_random1 == 0) {
										Console.ForegroundColor = ConsoleColor.Red;
										Console.Write("O");
									} else if (int_random2 == 0) {
								        Console.ForegroundColor = ConsoleColor.Yellow;
										Console.Write("I");
									} else {
								        Console.ForegroundColor = ConsoleColor.Green;
										Console.Write("X");
									}
									int_random1 = r.Next(0, 11);
									int_random2 = r.Next(0, 21);
								}
								Console.WriteLine("");
								cell_iteration++;
								if (cell_iteration >= 5) {
								    amount4 = cell_count * 2 - 1;
									cell_iteration = 0;
									cell_count++;
								} else {
								    amount4++;
								}
							}
							Console.ForegroundColor = ConsoleColor.DarkYellow;
							for (int i15 = 0; i15 < 3; i15++) {
							    for (int i16 = 0; i16 < (input_height - 1); i16++) {
									Console.Write(" ");
								}
								Console.WriteLine("H");
							}
							Console.ForegroundColor = ConsoleColor.White;
							break;
					}
					Console.Write("\nNoch ein Baum? <j/n>: ");
					string answer = Console.ReadLine();
					if (answer == "n" || answer == "N") {
					    run = false;
					}
					Console.Clear();
            }
        }
    }
}
