#include "Query.h"

struct Link
{
	Query query;
	Link *next;
};
class TQueue
{
	Link *head;
	Link *tail;
	int n;

public:

	/* Не забываем ставить проверки на пустоту!*/

	TQueue(void);
	bool IsEmpty() {return head == 0;}
	TQueue (const TQueue&);
	TQueue &Del();                 // удалить один элемент из начала очереди
	TQueue & Clear();              //удалить все элементы очереди
	int GetN() {return n;}         //получить кол-во элементов
	TQueue & Push (const Query &); // добавить элемент в конец очереди
	Query Pop();                   // извлечь элемент из начала очереди
	const Query & Get() const;     // посмотреть элемент в начале очереди
	~TQueue(){ Clear(); }
};
