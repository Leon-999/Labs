#include "Dijkstra.h"
#include "IStack.h"
#include "StackAllocator.h"
#include "MyString.h"
#include "iostream"

using namespace std;


double Dijkstra::parse(string * str)
{
	this->values = this->getValues(str);

	this->convertToPolish(str);
	
		
	double result = this->calculatePolish();

	cout<<"calculated result is: "<<result<<"\n";

	delete str;
	delete[] this->values;

	return result;
}

double Dijkstra::calculatePolish()
{
	StackAllocator<double> sA;

	IStack<double> * stack = sA.getStack();

	for (int i = 0; i < myStrlen(&(this->polishString)); i++)
	{
		char readCharacter = this->polishString[i];

		if (readCharacter == '*' || 
			readCharacter == '/' || 
			readCharacter == '+' ||
			readCharacter == '-')
		{
			double operand2 = stack->pop();
			double operand1 = stack->pop();
			char operation = readCharacter;

			stack->push(this->calculate(operand1, operation, operand2));
		}

		else //не операция => операнд
		{
			stack->push(this->values[readCharacter - 'a']);
		}
	}

	double toReturn = stack->pop();
	
	delete stack;
	return toReturn;
}

void Dijkstra::convertToPolish(string * str)
{
	StackAllocator<char> sA;

	IStack<char> * stack = sA.getStack();
	
	this->polishString = "";

	for (int i = 0; i < myStrlen(str); i++)
	{
		char readCharacter = (*str)[i];

		
		if (readCharacter == '(')
		{
			stack->push(readCharacter);
		}
		else if (readCharacter == '*' || readCharacter == '/')
		{
			char tmp = stack->pop();
			while (tmp == '*' || tmp == '/')
			{
				this->polishString += tmp;
				//tmp = '&';
				
				/*if (!stack.isEmpty())*/ tmp = stack->pop();
			}
			if (tmp != '\n') stack->push(tmp);

			stack->push(readCharacter);
		}
		else if (readCharacter == '+' || readCharacter == '-')
		{
			char tmp = stack->pop();
			while (tmp == '*' || tmp == '/' || tmp == '+' || tmp == '-')
			{
				this->polishString += tmp;
				//tmp = '&';
				
				/*if (!stack.isEmpty())*/ tmp = stack->pop();
			}
			if (tmp != '\n') stack->push(tmp);

			stack->push(readCharacter);
		}
		else if (readCharacter == ')')
		{
			char tmp = stack->pop();
			while (tmp != '(')
			{
				if (stack->isEmpty())
				{
					cout<<"parsing error, application probably falls in no time\n";
					system("PAUSE");

					break;
				}
				this->polishString += tmp;
				tmp = stack->pop();
			}
		}

		else //не операция => операнд
		{
			this->polishString += readCharacter;
		}

	}

	//теперь входная строка пройдена

	char tmp = '&';

	while (tmp != '(' && !stack->isEmpty())
	{
		tmp = stack->pop();
		this->polishString += tmp;
	}
	if (!stack->isEmpty())
	{
		cout<<"input is wrong\n";
		system("PAUSE");
	}


	this->polishString += 'ё';

	delete stack;
}


Dijkstra::Dijkstra()
{

}

void Dijkstra::help()
{
	cout<<"Input your formula. Round brackets and operations +, -, *, / are allowed.\n";
}