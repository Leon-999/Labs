#include "HDD.h"


HDD::HDD(void)
{
}

HDD::HDD(int inRoads, int inSectors, int inSectorSize)
{
	roads = inRoads;
	sectors = inSectors;
	sectorSize = inSectorSize;
}
HDD::~HDD(void)
{
}
