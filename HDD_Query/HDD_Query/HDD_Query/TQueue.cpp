#include "TQueue.h"


TQueue::TQueue(void)
{
	head = tail = 0;
}

TQueue::TQueue(const TQueue& q)
{
  head = tail = 0;
  *this = q;
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

const Query& TQueue::Get() const
{
  return head->query;
}

