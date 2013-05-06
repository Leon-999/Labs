#include "MyParser.h"
#include "iostream"
#include "MyString.h"

using namespace std;


char MyParser::getUnusedLetter(double * values, string * str)
{
	int i = 0;
	while (i < 1 + 'z' - 'a' && values[i] != numeric_limits<double>::min( ))
		i++;

	if (i == 1 + 'z' - 'a')
	{
		cout<<"We probably ran out of letters. Lucky we are, such\n"
			<<"event can be prevented. Wait for the nearest patch.\n"
			<<"\nWe're going to finish calculation anyway, so now\n"
			<<"you're probably getting wrong answer. Prepare! And,\n"
			<<"uh, sorry.\n\n";
		system("PAUSE");
		return 'a';
	}
	else return i + 'a';
}

double * MyParser::getValues(string * str)
{
	cout<<"Few more questions...\n";
	double * values = new double[1 + 'z' - 'a'];

	for (int i = 0; i < 1 + 'z' - 'a'; i++)
		values[i] = std::numeric_limits<double>::min( );
		//let's hope nobody will use 2.22507e-308

	for (int i = 0; i < myStrlen(str); i++)
	{
		if ((*str)[i] >= 'a' && (*str)[i] <= 'z')
			values[(*str)[i] - 'a']++;
	}

	for (int i = 0; i < 1 + 'z' - 'a'; i++)
	{
		if (values[i] >= 1)
		{
			cout<<char('a' + i)<<" = ";
			cin>>values[i];
		}
	}

	return values;
}

double MyParser::calculate(double operand1, char operator1, double operand2)
{
	double result = 0;

	if (operator1 == '+') result = operand1 + operand2;
	else if (operator1 == '-') result = operand1 - operand2;
	else if (operator1 == '*') result = operand1 * operand2;
	else if (operator1 == '/') result = operand1 / operand2;

	return result;
}

MyParser::MyParser()
{
	//why does it not links without this?
}

MyParser::~MyParser()
{
	//why does it not links without this?
}