#ifndef ___PARSER
#define ___PARSER 0

#include "string"

using namespace std;

class IParser
{

public:
	virtual double parse(string * str) = 0;
	virtual void help() = 0;

};

#endif