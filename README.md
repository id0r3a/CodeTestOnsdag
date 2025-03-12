📝 Uppgift – Hitta den mest frekventa siffran i en array

Beskrivning: Skriv en metod som tar emot en array av heltal och returnerar den mest förekommande siffran i array. Om flera siffror har samma frekvens, returnera den lägsta siffran.

Regler: ✅ Listan kan innehålla positiva och negativa heltal. ✅ Använd en Dictionary eller en lista för att hålla koll på förekomster. ✅ Optimera koden för att kunna hantera stora listor effektivt.

Exempel:

Input: [1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5] Output: 2 (Siffra 2 förekommer 4 gånger, vilket är mest)

Input: [7, 7, 5, 5, 1, 1, 1, 2, 2, 2] Output: 1 (Både 1 och 2 har 3 förekomster, men 1 är minst)

🖥 Kodmall (Studenter fyller i metoden)

public static int MestFrekventSiffra(int[] arr) { // TODO: Implementera frekvensräkning här }

// Testa funktionen Console.WriteLine(MestFrekventSiffra(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // 2 Console.WriteLine(MestFrekventSiffra(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 })); // 1
