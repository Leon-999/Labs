#include "Word.h"

Word::Word(void)
{

}
Word::Word(char* word)
{	
	{
		int i;
		for(i=0;word[i]!=0;++i);
		this->lenght=i+1;
	}
	this->sigla=new char[this->lenght];

	for(int i=0;word[i]!=0;++i)
	{
		this->sigla[i]=word[i];
	}

	this->sigla[this->lenght-1]=0;
	this->color=LightGray;
}


Word::~Word(void)
{
	delete [] this->sigla;
}

Word& Word::operator =(const Word *word)
{
	this->lenght=word->lenght;
	this->sigla=new char[this->lenght];
	for(int i=0;i<(word->lenght)-1;++i)
	{
		this->sigla[i]=word->sigla[i];
	}

	this->sigla[this->lenght-1]=0;
	return *this;
}

void Word::Print()
{
	TermColors* termColor=new TermColors();
	termColor->setConsoleColor(Black, this->color);
	printf("%s ",this->sigla);
}

char Word::getChar(int n)
{
	return this->sigla[n];
}

int Word::getLenght(void)
{
	return this->lenght;
}

int Word::countVowelInWord()
{
	int countVowel=0;
	int i=0;
	char tmpChar=this->sigla[i];
	while (tmpChar!=0)
	{
		if (tmpChar=='a' || tmpChar=='A' ||
			tmpChar=='e' || tmpChar=='E' ||
			tmpChar=='i' || tmpChar=='I' ||
			tmpChar=='o' || tmpChar=='O' ||
			tmpChar=='u' || tmpChar=='U' ||
			tmpChar=='y' || tmpChar=='Y')
			++countVowel;

		++i;
		tmpChar=this->sigla[i];
	}

	return countVowel;
}

void Word::setColor(int color)
{
	this->color=color;
}

int Word::getColor()
{
	return this->color;
}