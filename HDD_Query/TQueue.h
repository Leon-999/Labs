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
	int GetN() {return n;}         //получить кол-во элементов
	TQueue & Push (const Query &); // добавить элемент в конец очереди
	Query Pop();                   // извлечь элемент из начала очереди
	Query Pop(int number);  //извлечь элемент по номеру (номер стоит сверять с кол-вом элементов в очереди), номера начинаются с 1-цы
	const Query & Get() const;     // посмотреть элемент в начале очереди
	const Query & Get(int number) const; // посмотреть элемент по номеру
	~TQueue(){ Clear(); }

private:
	TQueue &Del();                 // удалить один элемент из начала очереди
	TQueue &Del(int number);	   // удалить элемент по номеру
	TQueue & Clear();              //удалить все элементы очереди
};
