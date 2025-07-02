
        // Tallaabo 1: Geli ID iyo Magac
        Console.Write("Fadlan geli ID-gaaga: ");
        string id = Console.ReadLine();

        Console.Write("Fadlan geli magacaga: ");
        string magac = Console.ReadLine();

        Console.WriteLine($"\nKu soo dhawoow, {magac}! (ID: {id})");

        // Tallaabo 2: Doorasho Xisaab
        Console.WriteLine("\nDooro nooca xisaabta aad rabto:");
        Console.WriteLine("1) Kudar");
        Console.WriteLine("2) Kajar");
        Console.WriteLine("3) Kudhufo");
        Console.WriteLine("4) Qaybi");

        Console.Write("\nGeli doorashada (1-4): ");
        int doorasho = Convert.ToInt32(Console.ReadLine());

        // Go’aami hawlgalka
        char calaamad = '+';
        Func<int, int, int> howlgal = (a, b) => a + b;

        switch (doorasho)
        {
            case 1:
                calaamad = '+';
                howlgal = (a, b) => a + b;
                break;
            case 2:
                calaamad = '-';
                howlgal = (a, b) => a - b;
                break;
            case 3:
                calaamad = '*';
                howlgal = (a, b) => a * b;
                break;
            case 4:
                calaamad = '/';
                howlgal = (a, b) => b == 0 ? 0 : a / b;
                break;
            default:
                Console.WriteLine("Doorasho khaldan. Barnaamijku wuu istaagay.");
                return;
        }

        // Tallaabo 3: Weydiinta 10 su’aalood
        int saxCount = 0;
        Random rnd = new Random();

        for (int i = 1; i <= 10; i++)
        {
            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);

            if (doorasho == 4)
                while (b == 0) b = rnd.Next(1, 10); // ka fogaanshaha qaybin eber

            int saxJawaab = howlgal(a, b);

            Console.Write($"\nSu’aal {i}: {a} {calaamad} {b} = ");
            bool ok = int.TryParse(Console.ReadLine(), out int userJawaab);

            if (!ok)
            {
                Console.WriteLine("➡️ Fadlan geli tiro sax ah.");
                i--; // isku day mar kale
                continue;
            }

            if (userJawaab == saxJawaab)
            {
                Console.WriteLine("✅ Waa sax!");
                saxCount++;
            }
            else
            {
                Console.WriteLine($"❌ Waa khalad! Jawaabta saxda ah waa: {saxJawaab}");
            }
        }

        // Tallaabo 4: Natiijada ugu dambeysa
        int khalad = 10 - saxCount;
        double boqolley = (saxCount / 10.0) * 100;

        Console.WriteLine("\n== Natiijadaada ==\n");

        // Headings
        Console.WriteLine($"{"ID",-10} {"Magac",-12} {"Sax",-8} {"Khalad",-10} {"Boqolley"}");

        // Qiimeyn
        Console.WriteLine($"{id,-10} {magac,-12} {saxCount,-8} {khalad,-10} {boqolley}%");
    