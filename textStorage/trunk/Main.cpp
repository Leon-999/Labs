#pragma once
#include "Document.h"
#include "TermColors.h"


char* handlingPath(char* lastPath)
{
	char* newPath = new char[1000];
	int iL=0;
	int iN;

	for(iL=0,iN=0; lastPath[iL]!=0; ++iL,++iN)
	{
		newPath[iN]=lastPath[iL];
		if (newPath[iN]==92)//'\'
		{
			++iN;
			newPath[iN]='\\';
		}
	}
	newPath[iN]=0;

	return newPath;
}

void printLegend()
{
	TermColors* termColor=new TermColors();

	termColor->setConsoleColor(Black, LightGray);
	printf("\n##### - default color\n");
	termColor->setConsoleColor(Black, Yellow);
	printf("#####");
	termColor->setConsoleColor(Black, LightGray);
	printf(" - words with to the entered number of vowels\n");
	termColor->setConsoleColor(Black, Cyan);
	printf("#####");
	termColor->setConsoleColor(Black, LightGray);
	printf(" - sentence with max number of such words\n");
	termColor->setConsoleColor(Black, Red);
	printf("#####");
	termColor->setConsoleColor(Black, LightGray);
	printf(" - paragraph with max length of such sentence\n");
	termColor->setConsoleColor(Black, Green);
	printf("#####");
	termColor->setConsoleColor(Black, LightGray);
	printf(" - comments\n\n");
}

void printDocument(Document* document)
{
	TermColors* termColor=new TermColors();

	termColor->setConsoleColor(Black, Green);
	printf("<Begin text>\n\n");
	document->Print();
	termColor->setConsoleColor(Black, Green);
	printf("\n<End text>\n");
}

void main (void)
{
	//"Liryc.txt"
	//"aboutAnimals.txt"
	bool endProgram = false;
	char* path = new char[1000];
	char* workPath = new char[1000];
	int countVowel;
	char* vote = new char[2];//c 1-чкой почему-то проблема возникает (при удалении)
	TermColors* termColor=new TermColors();

	while(!endProgram)
	{
		printf("Input the path unto TXT file.\n"); 
		printf("0 - default file will open.\n");
		scanf("%s",path);

		workPath=handlingPath(path);
		Document* document;

		if (path[0]=='0') 
			document = new Document("aboutAnimals.txt");
		else
			document = new Document(workPath);

		if (document->getFileOpen()!=0)
		{
			printf("\nInput the number vowels in word.\n"); 
			scanf("%d",&countVowel);

			printLegend();
			document->searchParagraphMaxWordCV(countVowel);
			printDocument(document);
		}
		else
		{
			printf("\nError path\n");
		}

		delete document;

		termColor->setConsoleColor(Black, LightGray);
		printf("\nClose the program? (y\\n)\n");
		scanf("%s",vote);
		if (vote[0] != 'n' && vote[0] != 'N')
		{
			endProgram=true;
		}
		printf("\n\n");
	}

	delete [] path;
	delete [] vote; //здесь та самая проблема возникает
}
