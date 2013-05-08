#pragma once
#include "Paragraph.h"
#include "Word.h"
#include "Sentence.h"
#include <stdio.h>

using namespace std;

struct ItemP
{
	Paragraph* paragraph;
	ItemP* nextParagraph;

	ItemP(char* word){this->paragraph=new Paragraph(); this->paragraph->addSentence(word); this->nextParagraph=0;};
	~ItemP(){};
};

class Document
{
private:
	ItemP* head;
	ItemP* tail;
	int lenght;
	FILE* file;
	bool fileOpen;
public:
	Document(char* path);
	~Document(void);
	void Print();
	void addParagraph(char* word);
	void addWord(char* word);
	Paragraph* searchParagraphMaxWordCV(int countVowel);
	int getFileOpen();
};

