int[] Number = new int[10];
  for (int i = 0; i < Number.Length; i++ )
  {
    Number[i] = new Random().Next(1, 10);
    Console.Write(Number[i] + " ");
  }

int maxNumber = Number[0];
int minNumber = Number[0];

  for (int i = 1; i < Number.Length; i++)
  {
    if (maxNumber < Number[i])
    {
      maxNumber = Number[i];
    }
        if (minNumber > Number[i])
    {
      minNumber = Number[i];
    }
  }

  int decision = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine($"РАзница {decision}");