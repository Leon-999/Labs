#include "QueryGenerator.h"


QueryGenerator::QueryGenerator(HDD inDisk)
{
	disk = inDisk;
}

Query QueryGenerator::GetQuery()
{
	/*
	FIX LATER:
		1) need to avoid situation when query requesting data which is out of disk space
		2) remove MAXSIZE
		3) road random genereting nonrandom values. wtf?
	*/
	srand (time(NULL));// initialize seed
	int roadNum = rand() % disk.GetRoadsNum();
	int sectorNum = rand() % disk.GetSectorsNum();
	int sectorShift = rand() % disk.GetSectorSize();
	int size = rand() % MAXSIZE;

	bool read = rand() % 2;

	return Query(roadNum, sectorNum, sectorShift, size, read);

}

QueryGenerator::~QueryGenerator(void)
{
}
