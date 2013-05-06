#pragma once
#include "Document.h"
#include <iostream>


Document::Document(char* path)
{
	char* boof;

	this->head=0;
	this->tail=0;
	this->lenght=0;
	this->fileOpen=false;

	bool checkEndSentence=false;

	if(this->file = fopen(path,"rt"))//0 - признак ошибки
	{
		this->fileOpen=true;
		char tmpChar;
		fscanf(this->file,"%c",&tmpChar);//this->file полностью считает файл

		int lenghtFile=this->file->_cnt;
		if(lenghtFile==0) //для коректной работы с пустыми файлами
		{
			this->file->_base[lenghtFile]=0;
			this->file->_base[lenghtFile+1]=0;
		}
		char* strFile=this->file->_base;

		boof=new char[1000];
	
		bool endSentence=false;
		bool endParagraph=true;

		for(int i=0,k=0; i<lenghtFile+2; ++i,++k)
		{
			boof[k]=strFile[i];
			if(boof[k]==' ' || boof[k]=='\n' || boof[k]=='\t'|| i==lenghtFile+1) //+1 - чтобы схватить последний символ
			{
				char tmpChar=boof[k];
				boof[k]=0;
				char* word=boof;

				if(endParagraph==true)
				{
					endParagraph=false;
					this->addParagraph(word);
				}
				else
					this->addWord(word);

				if(tmpChar=='\n' || tmpChar=='\t')
				{
					endParagraph=true;
				}

			k=-1;
			}

		}
	}
}


Document::~Document(void)
{
	if(this->fileOpen) fclose(this->file);
	fileOpen=false;
}

void Document::addParagraph(char* word)
{
	ItemP* tmpItem=new ItemP(word);


	if(this->head==0)
	{
		this->head=tmpItem;
		this->tail=tmpItem;
	}
	else
	{
		this->tail->nextParagraph = tmpItem;
		this->tail=tmpItem;
		++this->lenght;
	}
}

void Document::Print()
{
	ItemP* tmpItem=this->head;

	while(tmpItem!=0)
	{
		printf("%s","\t");
		tmpItem->paragraph->Print();
		printf("%s","\n");
		tmpItem=tmpItem->nextParagraph;
	}
}

void Document::addWord(char* word)
{
	this->tail->paragraph->addWord(word);
}

Paragraph* Document::searchParagraphMaxWordCV(int countVowel)
{
	Paragraph* foundParagraph=0;
	ItemP* tmpItem=this->head;
	int max = -1;
	int lenghtSentence=0;
	while(tmpItem!=0)
	{
		lenghtSentence=tmpItem->paragraph->searchSentenceMaxWordCV(countVowel);
		if(max < lenghtSentence)
		{
			max = lenghtSentence;
			foundParagraph=tmpItem->paragraph;
		}
		tmpItem=tmpItem->nextParagraph;
	}

	if (max!=0 && max!=-1) foundParagraph->swapColor(Red);

	return foundParagraph;
}

int Document::getFileOpen()
{
	return this->fileOpen;
}