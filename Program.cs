string[] data = File.ReadAllLines("../../../input.txt");


//Console.WriteLine("This is the data file:");
//Console.WriteLine(data);

int counter_increasing = 0;
int counter_decreasing = 0;

Console.WriteLine("Size of string:" + data.Length);


/*
var a = "55";
if (!int.TryParse(a, out var ll))
{
    //
}
ll.
*/
int comp1 = 0;
int comp2 = 0;


for (int i = 3; i < data.Length; i++)
{
    comp2 = 0;

    if(comp1 == 0)
    {
        for (int j = i - 3; j < i; j++)
            {
                comp1 += int.Parse(data[j]);

            }
        for(int j = i - 2; j <= i; j++)
            {
                comp2 += int.Parse(data[j]);
            }
        i++;
    }
    else
    {
        for (int j = i - 2; j <= i; j++)
        {
            comp2 += int.Parse(data[j]);
        }
    }


    if (comp1 < comp2)
        counter_increasing++;

    else if(comp1 > comp2)
        counter_decreasing++;

    comp1 = comp2;
}


Console.WriteLine("Counter increased: " + counter_increasing + " times.");
Console.WriteLine("Counter decreased: " + counter_decreasing + " times.");


