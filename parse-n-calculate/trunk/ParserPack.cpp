#include "ParserPack.h"
#include "iostream"
#include "string"
#include "Rutishauser.h"
#include "BauerAndZamelzon.h"
#include "Dijkstra.h"

using namespace std;

string * getString()
{
	string * str = new string();

	cout<<"By the way, you better use letters a-z instead of numbers.\n";
	
	cin>>*str;
	(*str) += "¸";
	cout<<"\n";

	return str;
}

ParserPack::ParserPack(void)
{
}


ParserPack::~ParserPack(void)
{
}


bool ParserPack::userRefusesParser(int id)
{
	IParser * parser = this->getParser(id);
	if (parser != 0)
	{
		parser->help();
		cout<<"Does it suits you? (Y/N)\n";
	
		char tmp;
		cin>>tmp;

		return tmp == 'N' || tmp == 'n';
	}
	else return true;
}
void ParserPack::callParser(int id)
{
	IParser * parser = 0;

	parser = this->getParser(id);
	parser->parse(getString());

	if (parser != 0) delete parser;
}
void ParserPack::coutParsersList()
{
	cout<<"Choose:\n"
		<<"1 - Rutishauser's algorithm\n"
		<<"2 - Bauer'n'Zamelzon's algorithm\n"
		<<"3 - Dijkstra, polish notation etc\n";
}


IParser * ParserPack::getParser(int id)
{
	if (id == 1)
	{
		return new Rutishauser();
	}
	else if (id == 2)
	{
		return new BauerAndZamelzon();
	}
	else if (id == 3)
	{
		return new Dijkstra();
	}
	else return 0;
}