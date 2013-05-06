#include "Sentence.h"


Sentence::Sentence(void)
{
	this->head=0;
	this->tail=0;
	this->lenght=0;
}


Sentence::~Sentence(void)
{
}

void Sentence::addWord(char* word)
{
	bool checkEnd=false;
	Word* tmpWord=new Word(word);
	ItemW* tmpItem = new ItemW(tmpWord);
	if(this->head==0)
	{
		this->head=tmpItem;
		this->tail=tmpItem;
	}
	else
	{
		this->tail->nextWord=tmpItem;
		this->tail=tmpItem;
	}
	++this->lenght;
}

void Sentence::Print()
{
	ItemW* tmpItem=this->head;

	while(tmpItem!=0)
	{
		tmpItem->word->Print();
		tmpItem=tmpItem->nextWord;
	}
}

void Sentence::clear()
{
	ItemW* searcher=this->head;
	ItemW* deleted;
	while(searcher->nextWord!=0)
	{
		deleted=searcher;
		searcher=searcher->nextWord;
		delete deleted;
	}
	this->head=0;
	this->head->nextWord=0;
	this->lenght=0;

}

int Sentence::getLenght()
{
	return this->lenght;
}

ItemW* Sentence::getWord(int n)
{
	ItemW* tmpItem;
	int i;
	for(i=1, tmpItem=this->head; i<n && tmpItem->nextWord!=0; tmpItem=tmpItem->nextWord,++i);

	return tmpItem;
}

int Sentence::countWordsCV(int countVowel)
{
	int countWords=0;
	ItemW* tmpItem=this->head;
	while(tmpItem!=0)
	{
		if(countVowel == tmpItem->word->countVowelInWord())
		{
			tmpItem->word->setColor(Yellow);
			++countWords;
		}
		tmpItem=tmpItem->nextWord;
	}

	return countWords;
}

void Sentence::swapColor(int color)
{
	ItemW* tmpItem=this->head;
	while(tmpItem!=0)
	{
		if (tmpItem->word->getColor()!=Yellow && tmpItem->word->getColor()!=Cyan) tmpItem->word->setColor(color);
		tmpItem = tmpItem->nextWord;
	}
}