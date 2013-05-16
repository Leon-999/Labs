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
	//начало
	TQueue* tQueue = new TQueue();

	printf("Wait, please.\n\n");
	for (int i = 0; i < 10; i++)
	{
		tQueue->Push(queryGenerator.GetQuery());
		Sleep(300);
	}
	Query tmp = tQueue->Get(7);//смотрю на 7 элемент, но из очереди не удал€ю
	tQueue->Pop(7);//извлекаю 7 элемент, но не печатаю, в очереди остаЄтс€ 9 элементов
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
	//конец

	//код ниже вполне рабочий, код выше лишь показывает новые возможности

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