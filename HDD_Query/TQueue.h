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
	int GetN() {return n;}         //�������� ���-�� ���������
	TQueue & Push (const Query &); // �������� ������� � ����� �������
	Query Pop();                   // ������� ������� �� ������ �������
	Query Pop(int number);  //������� ������� �� ������ (����� ����� ������� � ���-��� ��������� � �������), ������ ���������� � 1-��
	const Query & Get() const;     // ���������� ������� � ������ �������
	const Query & Get(int number) const; // ���������� ������� �� ������
	~TQueue(){ Clear(); }

private:
	TQueue &Del();                 // ������� ���� ������� �� ������ �������
	TQueue &Del(int number);	   // ������� ������� �� ������
	TQueue & Clear();              //������� ��� �������� �������
};
