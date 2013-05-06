#ifndef ___MYPARSER
#define ___MYPARSER 0

#include "IParser.h"
#include "string"

using namespace std;

class MyParser : public IParser
{

protected:
	double * getValues(string * str);
	char getUnusedLetter(double * values, string * str);

	double calculate(double operand1, char operator1, double operand2);

public:
	MyParser();
	~MyParser();
};

#endif