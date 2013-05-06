#ifndef ___DIJKSTRA
#define ___DIJKSTRA 0

#include "MyParser.h"
#include "string"

using namespace std;

class Dijkstra : public MyParser
{

private:
	string polishString;
	double * values;

	void convertToPolish(string * str);
	double calculatePolish();
	
public:
	Dijkstra();
	~Dijkstra();
	double parse(string * str);
	void help();

};

#endif