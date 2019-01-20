#include <fstream>
#include <cstdio>
#include <string>
#include "stdafx.h"

int main(int argc, char* argv[])
{
	if(argc < 1)
		PrintUsage();
	
	if (!FileExists(argv[1]))
		PrintError((char*)"Please Use Full Path To TOC File...",argv[1]);



	system("pause");
}

void PrintUsage()
{
	printf("Aspect - TOC/DAT Extractor Usage.\n\n");
	printf("[-p --path]: Path To TOC File.\n");
	printf("[-x --extract]: Extract Path. (Defaults To Aspect Running Directory)");
	exit(1);
}

void PrintError(char *Msg,char* FileSpecified)
{
	printf(Msg);
	printf(FileSpecified);
}

bool FileExists(char * File)
{
	std::ifstream f(File);
	return f.good();
}

