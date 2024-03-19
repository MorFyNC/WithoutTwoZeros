Console.WriteLine(Count(2,4));

int Count(int zeros, int ones)
{
    if (zeros > ones + 1) return 0;
    if (zeros == 0 || ones == 0) return 1;
    return Count(zeros, ones - 1) + Count(zeros - 1, ones - 1);
}