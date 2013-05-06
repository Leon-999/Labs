#pragma once

template <class T>
class ListItem
{
public:
	ListItem(T newData)
	{
		this->data = newData;
		this->previous = 0;
	}
	~ListItem(void)
	{

	}

	ListItem<T> * previous;
	T data;
};

