#pragma once
#include "HDD.h"
#include "Query.h"
#include <stdlib.h>
#include <time.h>  

#define MAXSIZE 1024*1042*1024 // maximum byte size for single query


class QueryGenerator
{
private:
	HDD disk;
friend Query;

public:
	QueryGenerator(HDD inDisk);
	Query GetQuery();
	~QueryGenerator(void);
};

