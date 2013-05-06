#pragma once

#include "Rutishauser.h"
#include "BauerAndZamelzon.h"
#include "Dijkstra.h"

class ParserPack
{

private:
	IParser * getParser(int id);

public:
	ParserPack(void);
	~ParserPack(void);

	//void coutHelp(int id);
	void callParser(int id);
	void coutParsersList();
	bool userRefusesParser(int id);
};

