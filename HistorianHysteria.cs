using System;

int[] leftlist = {}; //erste liste

int[] rightlist = {}; //zweite liste

Array.Sort(leftlist); // sortieren der listen
Array.Sort(rightlist);


//ausrechnen der differenz
int diff = 0;
for (int i = 0; i < leftlist.Length; i++)
{
    diff += Math.Abs(leftlist[i] - rightlist[i]);
}

Console.WriteLine($"{diff}");
