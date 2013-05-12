#pragma once
class Query
{
private:
	/* 
	№ дорожки
	№ сектороа
	смещение от начала сектора
	объем байтов
	запрос (читать/записывать)
	*/

	int roadNum;
	int sectorNum;
	int sectorShift;
	int size;
	bool read;

public:
	Query(void);
	Query(int inRoadNum, int inSectorNum, 
		  int inSectorShift, int inSize, bool inRead);

	void SetQuery(int inRoadNum, int inSectorNum, 
		  int inSectorShift, int inSize, bool inRead)
	{
		roadNum = inRoadNum;
		sectorNum = inSectorNum;
		sectorShift = inSectorShift;
		size = inSize;
		read = inRead; 
	}

	int GetRoad() {return roadNum;}
	int GetSector() {return sectorNum;}
	int GetSectorShift() {return sectorShift;}
	int GetSize() {return size;}
	bool IsRead() {return read;}

	~Query(void);
};

