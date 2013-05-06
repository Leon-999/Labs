#ifndef ___RUSTY
#define ___RUSTY 0

#include "MyParser.h"
#include "string"

using namespace std;

class Rutishauser : public MyParser
{
	char * getLevels(string * str);

public:
	Rutishauser();
	~Rutishauser();
	double parse(string * str);
	void help();

};

#endif