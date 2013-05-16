#include "TQueue.h"


TQueue::TQueue(void)
{
	head = tail = 0;
	this->n = 0;
}

TQueue::TQueue(const TQueue& q)
{
  head = tail = 0;
  *this = q;
  this->n = q.n;
}

TQueue& TQueue::Clear()
{
  while(!IsEmpty()) Del();
  return *this;
}

TQueue& TQueue::Del()
{
	  Link* tmp = head->next; 
	  delete head; 
	               
	  if(!tmp)  
		head = tail = 0;
	  else
		head = tmp;
	  n--;
	  return *this;
}

TQueue& TQueue::Del(int number)
{
	Link* lastItem = this->head;
	Link* item;
	Link* delItem;
	int i;

	if (number == this->n)
	{
		delItem = this->tail;
		this->tail = lastItem;
		delete delItem;
		this->n--;
	}
	else
		for(item = this->head, i = 1; item->next != 0; lastItem = item, item = item->next, ++i)
		{
			if(i == number) 
			{
				Link* delItem;
				if(i == 1) this->Del();
				else
				{
					delItem = item;
					lastItem->next = item->next;
					delete delItem;
					this->n--;
				}
				break;
			}
		}

	return *this;
}


TQueue& TQueue::Push(const Query& q)
{
  Link* item = new Link;
  item->query = q;
  item->next = 0;
  if(!head)
  {
    head = item;
    tail = head;
  } 
  else
  {
    tail->next = item;
    tail = item;
  }
  n++;
  return *this;
}

Query TQueue::Pop()
{
  Query q = head->query;
  Del();
  return q;
 }

Query TQueue::Pop(int number)
{
	Query getingElement;
	Link* item;
	int i;
	if(number == this->n)
	{
		getingElement = this->tail->query;
		this->Del(this->n);
	}
	else
		for(item = this->head, i = 1; item->next != 0; item = item->next, ++i)
		{
			if(i == number) 
			{
				getingElement = item->query;
				this->Del(number);
				break;
			}
		}

	return getingElement;
}

const Query& TQueue::Get() const
{
  return head->query;
}

const Query& TQueue::Get(int number) const
{
	Query getingElement;
	Link* item;
	int i;

	if(number == this->n) getingElement = this->tail->query;
	else
		for(item = this->head, i = 1; item->next != 0; item = item->next, ++i)
		{
			if(i == number) 
			{
				getingElement = item->query;
				break;
			}
		}

  return getingElement;
}


