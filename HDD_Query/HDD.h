#pragma once
class HDD
{
	/*
	each road must have different length insted of constant length like here. 
	FIX LATER
	*/
protected:
	int roads;
	int sectors;
	int sectorSize;

public:
	HDD(void);
	HDD(int inRoads, int inSectors, int inSectorSize);
	int GetRoadsNum() { return roads;}
	int GetSectorsNum() { return sectors;}
	int GetSectorSize() { return sectorSize;}

	~HDD(void);
};

