#include "Rutishauser.h"
#include "iostream"
#include "string"
#include "MyString.h"

using namespace std;

double Rutishauser::parse(string * str)
{
	double * values = this->getValues(str);
	char * levels = this->getLevels(str);

	int startingLength = myStrlen(str);

	double result = 0;

	while (myStrlen(str) > 3)
	{
		int max = 0;
		int maxI = 0;

		for (int i = 0; i < myStrlen(str); i++)
		{
			if (levels[i] > max)
			{
				maxI = i;
				max = levels[i];
			}
		}

		levels;
		//найден максимальный уровень...

		double operand1 = values[(*str)[maxI] - 'a'];
		char localOperator = (*str)[maxI+1];
		double operand2 = values[(*str)[maxI+2] - 'a'];

		double localResult = this->calculate(operand1, localOperator, operand2);
		
		//вычислена тройка...

		char newLetter = this->getUnusedLetter(values, str);

		values[newLetter - 'a'] = localResult;

		(*str)[maxI - 1] = newLetter;

		int j = -1;
		do 
		{
			j++;
			(*str)[maxI + j] = (*str)[maxI + j + 4];
			levels[maxI + j] = levels[maxI + j + 4];
		}
		while ((*str)[maxI + j] != 'ё');

		for (int i = maxI + j + 4; i < startingLength; i++)
			levels[i] = 0;
		
		//тройка и её скобки заменены результатом
	}
	
	if (myStrlen(str) == 1)
	{
		result = values[(*str)[0] - 'a'];
		cout<<"Calculated number is "<<result<<"\n\n";
	}
	else cout<<"Something went wrong, I honestly don't know what to say.\n";


	delete[] values;
	delete[] levels;
	delete str;

	return result;
}

char * Rutishauser::getLevels(string * str)
{
	char * levels = new char[myStrlen(str)];
	int current = 0; 
	
	for (int i = 0; i < myStrlen(str); i++)
	{
		if ((*str)[i] == '(' || 
		   ((*str)[i] >= 'a' && (*str)[i] <= 'z'))
		{
			current++;
		}
		else if ((*str)[i] == ')' || 
				 (*str)[i] == '+' || 
				 (*str)[i] == '-' || 
				 (*str)[i] == '*' || 
				 (*str)[i] == '/')
		{
			current--;
		}
		
		levels[i] = current;
	}

	if (current != 1) 
	{
		cout<<"Something is wrong with your formula, but we'll proceed\n" 
			<<"and compute I-don't-know-what anyway; it will probably\n"
			<<"result in the total application crash. So be it. \n";
		system("PAUSE");
	}
	return levels;
}

Rutishauser::Rutishauser()
{
	//why does it not links without this?
}


void Rutishauser::help()
{
	cout<<"Input your formula, using every possible round bracket.\n";
}