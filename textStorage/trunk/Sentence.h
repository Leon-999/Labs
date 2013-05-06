#pragma once
#include "Word.h"
#include "TermColors.h"

struct ItemW
{
	ItemW* nextWord;
	Word* word;

	ItemW(Word* word) {this->word=word; this->nextWord=0;};
	~ItemW(){};
};

class Sentence
{
private:
	ItemW* head;
	ItemW* tail;
	int lenght;
public:
	Sentence(void);
	~Sentence(void);
	void Print();
	void clear();
	ItemW* getWord(int n);
	int getLenght();
	void addWord(char* word);
	int countWordsCV(int countVowel);
	void swapColor(int color);
};

