using System;

class Program{

    static void Printstall(char[] n){
        int i = 0;
        while(true){
            if (i < n.Length){
                Console.Write(n[i]);
                i++;
            } else {
                break;
            }
        }
    }

    static void input(char[] n){
        Console.WriteLine();
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (x > 0 && x <= n.Length){
            if (n[x-1] == '_'){
                n[x-1] = 'X';
                int count = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] == 'X'){
                        count++;
                    }
                }
                if (count == n.Length){
                    Console.WriteLine("The entrance can’t be reserved.");
                    n[x-1] = '_';
                }
            } else {
                Console.WriteLine("The stall is reserved.");
            }
        }
        if (y > 0 && y <= n.Length){
            if (n[y-1] == '_'){
                n[y-1] = 'X';
                int count = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] == 'X'){
                        count++;
                    }
                }
                if (count == n.Length){
                    Console.WriteLine("The entrance can’t be reserved.");
                    n[y-1] = '_';
                }
            } else {
                Console.WriteLine("The stall is reserved.");
            }
        }

    }

    static void Main(string[] args){
        Console.Clear();

        int quantity = int.Parse(Console.ReadLine());
        char[] n = new char[quantity];

        for (int i = 0; i < n.Length; i++)
        {
            n[i] = '_';
        }

        while(true){
            Printstall(n);
            input(n);

            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 'X'){
                    count++;
                }
            }

            //Console.WriteLine(count);

            if (count >= n.Length-1){
                    Console.WriteLine("All stall are reserved.");
                    break;
            }
        }

        //Console.ReadLine();
    }
}