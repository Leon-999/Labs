#pragma once

#include "IStack.h"
#include "TArrayStack.h"
#include "TListStack.h"

template <class T>
class StackAllocator
{
public:
	StackAllocator(void)
	{

	}
	~StackAllocator(void)
	{

	}

	IStack<T> * getStack()
	{
		cout<<"What type of stack will you use?\n"
			<<"1 - Based on arrays;\n"
			<<"2 - Based on linear list.\n";

		int tmp;
		cin>>tmp;

		if (tmp == 1) return new TArrayStack<T>;
		else return new TListStack<T>;
	}
};

