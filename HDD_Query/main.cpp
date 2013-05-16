#include <stdio.h>
#include "HDD.h"
#include "QueryGenerator.h"
#include "TQueue.h"
#include <stdlib.h>
#include <Windows.h>
int main()
{
	HDD hdd(10000, 700, 512);
	QueryGenerator queryGenerator(hdd);
	//������
	TQueue* tQueue = new TQueue();

	printf("Wait, please.\n\n");
	for (int i = 0; i < 10; i++)
	{
		tQueue->Push(queryGenerator.GetQuery());
		Sleep(300);
	}
	Query tmp = tQueue->Get(7);//������ �� 7 �������, �� �� ������� �� ������
	tQueue->Pop(7);//�������� 7 �������, �� �� �������, � ������� ������� 9 ���������
	for (int i = 0; tQueue->GetN() != 0; i++)
	{
		Query curQuery = tQueue->Pop();
		if ( curQuery.IsRead() )
			printf("Requesting: READ %d bytes from %d road, %d sector with %d shift\n",
				curQuery.GetSize(), curQuery.GetRoad(), curQuery.GetSector(),
				curQuery.GetSectorShift() );
		else
			printf("Requesting: WRITE %d bytes from %d road, %d sector with %d shift\n",
				curQuery.GetSize(), curQuery.GetRoad(), curQuery.GetSector(),
				curQuery.GetSectorShift() );

		Sleep(500);
	}

	system("pause");
	//�����

	//��� ���� ������ �������, ��� ���� ���� ���������� ����� �����������

	/*for (int i = 0; i < 30; i++)
	{
		Query curQuery = queryGenerator.GetQuery();
		if ( curQuery.IsRead() )
			printf("Requesting: READ %d bytes from %d road, %d sector with %d shift\n",
				curQuery.GetSize(), curQuery.GetRoad(), curQuery.GetSector(),
				curQuery.GetSectorShift() );
		else
			printf("Requesting: WRITE %d bytes from %d road, %d sector with %d shift\n",
				curQuery.GetSize(), curQuery.GetRoad(), curQuery.GetSector(),
				curQuery.GetSectorShift() );

		Sleep(3000);
	}*/
}