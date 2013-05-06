#include "BauerAndZamelzon.h"
#include "iostream"
#include "StackAllocator.h"
#include "IStack.h"

using namespace std;

BauerAndZamelzon::BauerAndZamelzon()
{
	this->parsingStatus = TO_CONTINUE;
}

double BauerAndZamelzon::parse(string * stringToParse)
{
	StackAllocator<char> sA;
	this->operands = sA.getStack();
	this->operations = sA.getStack();

	this->str = stringToParse;
	this->parsingPointer = 0;

	this->values = this->getValues(str);

	double result = 0;

	////////////
	// parsing begins

	while (this->parsingStatus == TO_CONTINUE)
	{
		char readCharacter = (*str)[parsingPointer];

		if (readCharacter == 'ё')
		{
			if (this->operations->isEmpty())
				this->f6();
			else if (this->operations->popAndRestore() == '(')
				this->f5();
			else
				this->f4();
		}
		else if (readCharacter == '(')
		{
			this->f1();
		}
		else if (readCharacter == '+' || readCharacter == '-')
		{
			if (this->operations->isEmpty() || this->operations->popAndRestore() == '(')
				this->f1();
			else if (this->operations->popAndRestore() == '+' || this->operations->popAndRestore() == '-')
				this->f2();
			else
				this->f4();
		}
		else if (readCharacter == '*' || readCharacter == '/')
		{
			if (this->operations->isEmpty() || this->operations->popAndRestore() == '(')
				this->f1();
			else if (this->operations->popAndRestore() == '+' || this->operations->popAndRestore() == '-')
				this->f1();
			else
				this->f2();
		}
		else if (readCharacter == ')')
		{
			if (this->operations->isEmpty())
				this->f5();
			else if (this->operations->popAndRestore() == '(')
				this->f3();
			else
				this->f4();
		}

		else //не операция => операнд
		{
			this->operands->push(readCharacter);
			this->parsingPointer++;
		}
	}

	if (this->parsingStatus == ERROR_OCCURED)
	{
		cout<<"Something went wrong\n\n";
	}

	else //implying everything is ok
	{
		result = values[this->operands->pop() - 'a'];
		cout<<"Calculated result is: "<<result<<"\n\n";
	}

	// parsing ends
	/////////////
	
	delete[] this->values;
	delete this->str;
	delete this->operands;
	delete this->operations;

	return result;
}

void BauerAndZamelzon::f1()
{
	this->operations->push((*str)[parsingPointer]);

	this->parsingPointer++;
}
void BauerAndZamelzon::f2()
{
	this->f4();

	this->operations->push((*str)[parsingPointer]);

	this->parsingPointer++;
}
void BauerAndZamelzon::f3()
{
	this->operations->pop();
	this->parsingPointer++;
}
void BauerAndZamelzon::f4()
{
	double operand2 = values[this->operands->pop() - 'a'];
	double operand1 = values[this->operands->pop() - 'a'];
	char operation = this->operations->pop();

	double localResult = this->calculate(operand1, operation, operand2);
		
	//вычислена тройка...

	char newLetter = this->getUnusedLetter(values, str);

	values[newLetter - 'a'] = localResult;

	this->operands->push(newLetter);
}
void BauerAndZamelzon::f5()
{
	this->parsingStatus = ERROR_OCCURED;
}
void BauerAndZamelzon::f6()
{
	this->parsingStatus = ENDED;
}

void BauerAndZamelzon::help()
{
	cout<<"Input your formula. Round brackets and operations +, -, *, / are allowed.\n";
}