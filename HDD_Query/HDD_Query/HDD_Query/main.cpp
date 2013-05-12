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

	for (int i = 0; i < 30; i++)
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
	}
}