#include "string"
#include "MyString.h"

using namespace std;

int myStrlen(string * str)
{
	int i = 0;

	while ((*str)[i] != '¸')
		i++;

	return i;
}