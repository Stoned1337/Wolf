#include <fstream>
#include <cstdio>

#include "stdafx.h"

int main(int argc, char** argv[])
{
	if(argc < 2)
		PrintUsage();

	CheckArgs(*argv, argc);
}

void PrintUsage()
{
	printf("Aspect - TOC/DAT Extractor Usage.\n\n");
	printf("[-p --path]: Path To TOC File.\n");
	printf("[-x --extract]: Extract Path. (Defaults To Aspect Running Directory)");
}