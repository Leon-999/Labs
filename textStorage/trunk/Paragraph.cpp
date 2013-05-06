#include "Paragraph.h"


Paragraph::Paragraph(void)
{
	this->head=0;
	this->tail=0;
	this->lenght=0;
	endSentence=false;
}


Paragraph::~Paragraph(void)
{

}

void Paragraph::Print()
{
	ItemS* tmpItem=this->head;

	while(tmpItem!=0)
	{
		tmpItem->sentence->Print();
		tmpItem=tmpItem->nextSentence;
	}
}

void Paragraph::addSentence(char* word)
{
	ItemS* tmpItem = new ItemS(word);
	if(this->head==0)
	{
		this->head=tmpItem;
		this->tail=tmpItem;
	}
	else
	{
		this->tail->nextSentence=tmpItem;
		this->tail=tmpItem;
	}
	++this->lenght;
}

void Paragraph::addWord(char* word)
{
	if(this->endSentence==true)
			{
				this->endSentence=false;
				this->addSentence(word);
			}
			else
			{
				this->tail->sentence->addWord(word);
			}

	int k;
	for(k=0;word[k]!=0;++k);

	if(word[k-1]=='.' || word[k-1]=='!' || word[k-1]=='?')
	{
		this->endSentence=true;
	}

}

int Paragraph::searchSentenceMaxWordCV(int countVowel)
{
	ItemS* tmpItem=this->head;
	Sentence* sentenceMaxWordCV;
	int max = -1;
	int tmp;
	int countWordCVInParagraph=0;
	int lenghtMaxSentence=0;
	while(tmpItem!=0)
	{
		tmp=tmpItem->sentence->countWordsCV(countVowel);
		countWordCVInParagraph += tmp;
		if(max < tmp)
		{
			max=tmp;
			sentenceMaxWordCV=tmpItem->sentence;
		}
		tmpItem=tmpItem->nextSentence;
	}
	
	if (max!=0 && max!=-1)
	{
		sentenceMaxWordCV->swapColor(Cyan);
		lenghtMaxSentence=sentenceMaxWordCV->getLenght();
	}
	return lenghtMaxSentence;
}

void Paragraph::swapColor(int color)
{
	ItemS* tmpItem=this->head;
	while(tmpItem!=0)
	{
		tmpItem->sentence->swapColor(color);
		tmpItem=tmpItem->nextSentence;
	}
}