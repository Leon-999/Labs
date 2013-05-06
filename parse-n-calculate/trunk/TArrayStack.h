#pragma once

#include "IStack.h"

template <class T>
class TArrayStack : public IStack<T>
{
	T * arr;
	int arrSize, used;

	void reallocate(int newSize)
	{
		T * newArr = new T[newSize];
		for (int i = 0; i < arrSize; i++)
		{
			newArr[i] = arr[i];
		}
		delete[] arr;
		arr = newArr;
		arrSize = newSize;
	}



public:

	void push(T newItem)
	{
		if (used == arrSize)
			reallocate(arrSize + 10);
		arr[used] = newItem;
		used++;
	}
	
	T pop()
	{
		if (used > 0) 
		{
			used--;
			return arr[used];
		}
		else return T('\n');
	}

	T popAndRestore()
	{
		T tmp = this->pop();
		this->push(tmp);

		return tmp;
	}

	bool isEmpty()
	{
		return used == 0;
	}

	TArrayStack(int newSize = 20)
	{
		arr = new T[newSize];
		used = 0;
		arrSize = newSize;
	}
	~TArrayStack()
	{
		delete[] arr;
	}
};