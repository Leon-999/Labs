#pragma once

#include "IStack.h"
#include "ListItem.h"

template <class T>
class TListStack : public IStack<T>
{

private:
	ListItem<T> * topItem;

	void deleteTopItem()
	{
		ListItem<T> * tmp = this->topItem->previous;
		delete this->topItem;
		this->topItem = tmp;
	}

public:
	TListStack()
	{
		this->topItem = 0;
	}
	~TListStack(void)
	{
		while (this->topItem != 0)
			this->deleteTopItem();
	}

	void push(T newItem)
	{
		ListItem<T> * tmp = new ListItem<T>(newItem);
		tmp->previous = this->topItem;

		this->topItem = tmp;
	}
	T pop()
	{
		if (this->topItem != 0)
		{
			T tmp = this->topItem->data;

			this->deleteTopItem();
			return tmp;
		}

		else return T('\n');
	}


	//bonus
	T popAndRestore()
	{
		T tmp = this->pop();
		this->push(tmp);

		return tmp;
	}
	bool isEmpty()
	{
		return this->topItem == 0;
	}
};

