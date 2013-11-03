ExHelp
======

A Exception Helper Library
 
Simple Exception Helper Class that allows a developer to re-use the 
library to defensively program against nulls and empty collections.

Simple enough to use:

Checking for empty strings:

ExceptionHelper.CheckForEmptyString(myString);

Check for Null object:

ExceptionHelper.CheckForNull(myObject);

Check For Empty Collection:

IEnumberable<string> myList = GetList();
ExceptionHelper.CheckForEmptyList(myList);

Check For Empty Dictionary: 

IDictionary<string,int> myDict = GetDict();
ExceptionHelper.CheckForEmpty(myDict);

Check Dictionary For Key:

IDictionary<string,int> myDict = GetDict();
ExceptionHelper.CheckContainsKey(myDict,"Fishsticks");

Usage Terms
======

Use this library for free in any project.
