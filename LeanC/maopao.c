#include <stdio.h>
#include <stdlib.h>

int main(int* argv[], char* argc[])
{
	int iI_array[10];

	printf("Please input 10 numbers to here:");
	for (int i = 0; i < 10; i++)
	{
		scanf_s("%d", &iI_array[i]);
	}
	for (int i = 0; i < 9; i++)
	{
		for (int j = 0; j < 9 - i; j++)
		{
			if (iI_array[j] < iI_array[j+1])
			{
				int tmp;
				tmp = iI_array[j];
				iI_array[j] = iI_array[j + 1];
				iI_array[j + 1] = tmp;
			}
		}
	}
	for (int i = 0; i < 10; i++)
	{
		printf("%d ", iI_array[i]);
	}
	system("pause");

	return 0;
}