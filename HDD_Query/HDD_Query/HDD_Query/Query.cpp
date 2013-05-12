#include "Query.h"


Query::Query(void)
{
	roadNum = 0;
	sectorNum = 0;
	sectorShift = 0;
	size = 0;
	read = 0;
}

Query::Query(int inRoadNum, int inSectorNum, 
			 int inSectorShift, int inSize, bool inRead)
{
	roadNum = inRoadNum;
	sectorNum = inSectorNum;
	sectorShift = inSectorShift;
	size = inSize;
	read = inRead;
}

Query::~Query(void)
{
}
