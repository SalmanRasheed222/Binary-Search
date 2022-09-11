



int[] items = new int[6];
int search, first=0, mid,last;
last = items.Length - 1;


for (int i=0; i < items.Length; i++)
{
	Console.WriteLine("Enter Values:");
	items[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter Search Value:");
search = Convert.ToInt32(Console.ReadLine());



while (first <= last)
{
	mid = (first + last) / 2;

	if (search == items[mid])
	{
		Console.WriteLine("value found at:"+(mid+1));
		return;
	}

	else if (search > items[mid])
	{
		first = mid + 1;
	}
	else
	{
		last = mid - 1;
	}

}


Console.WriteLine("Value Not Found !");







