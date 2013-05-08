#pragma once
#include <iostream>
#include "TermColors.h"

class Word
{
private:
	char* sigla;
	int lenght;
	int color;

public:
	Word(void);
	Word(char* word);
	~Word(void);
	Word& operator=(const Word *word);
	void Print();
	char getChar(int n);
	int getLenght(void);
	void addWord(char* word);
	int countVowelInWord();
	void setColor(int color);
	int getColor();
};

