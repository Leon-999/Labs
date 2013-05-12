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

	/* �� �������� ������� �������� �� �������!*/

	TQueue(void);
	bool IsEmpty() {return head == 0;}
	TQueue (const TQueue&);
	TQueue &Del();                 // ������� ���� ������� �� ������ �������
	TQueue & Clear();              //������� ��� �������� �������
	int GetN() {return n;}         //�������� ���-�� ���������
	TQueue & Push (const Query &); // �������� ������� � ����� �������
	Query Pop();                   // ������� ������� �� ������ �������
	const Query & Get() const;     // ���������� ������� � ������ �������
	~TQueue(){ Clear(); }
};
