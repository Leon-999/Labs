#pragma once
#include "Sentence.h"

struct ItemS
{
	Sentence* sentence;
	ItemS* nextSentence;

	ItemS(char* word){this->sentence = new Sentence(); this->sentence->addWord(word); this->nextSentence=0;};
	~ItemS();
};

class Paragraph
{
private:
	ItemS* head;
	ItemS* tail;
	int lenght;
	bool endSentence;
public:
	Paragraph(void);
	~Paragraph(void);
	void Print();
	void addSentence(char* word);
	void addWord(char* word);
	int searchSentenceMaxWordCV(int countVowel);
	void swapColor(int color);
};

