#ifndef __ISTACK
#define __ISTACK 0

template <class T>
class IStack
{

public:
	//core
	virtual void push(T newItem) = 0;
	virtual T pop() = 0;


	//bonus
	virtual T popAndRestore() = 0;
	virtual bool isEmpty() = 0;

};

#endif