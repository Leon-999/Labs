#ifndef ___BAUANZA
#define ___BAUANZA 0

#include "MyParser.h"
#include "string"
#include "IStack.h"

using namespace std;

const int ENDED = 0;
const int TO_CONTINUE = 1;
const int ERROR_OCCURED = 2;

class BauerAndZamelzon : public MyParser
{

private:
	void f1();
	void f2();
	void f3();
	void f4();
	void f5();
	void f6();

	int parsingStatus;
	IStack<char> * operations;
	IStack<char> * operands;

	int parsingPointer;
	string * str;
	double * values;

public:
	BauerAndZamelzon();
	~BauerAndZamelzon();
	double parse(string * str);
	void help();

};

#endif