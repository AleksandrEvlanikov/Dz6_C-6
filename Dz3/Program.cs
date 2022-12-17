int[] number = new int[5];
Random rnd = new Random();

int sum = 0;
int sum1 = 0;

for( int i = 0; i < 5; i++)
{
    number[i] = rnd.Next(1, 60);
}


sum = number[0] + number[4];
sum1 = number[1] + number[3];

sum = sum + sum1;

Console.WriteLine(sum);