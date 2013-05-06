#include "iostream"
#include "ParserPack.h"

using namespace std;



int main()
{
	ParserPack parsers;

	while (true)
	{
		int tmp;

		do
		{
			parsers.coutParsersList();

			cin>>tmp;
		} while (parsers.userRefusesParser(tmp));

		parsers.callParser(tmp);

		cout<<"Awesome, would you like another calculation?\n1 - Yes\n2 - No\n\n";
		cin>>tmp;

		if (tmp == 2) return 0;
	}
}