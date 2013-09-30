Code Contract Analysis
======================

This repo demonstrates a problem with the Code Contracts tool and the Code Coverage highlighting tool for Visual Studio.

There are 3 assemblies:

* Interfaces
* Implementations
* Tests

Interfaces defines a collections of interfaces and abstract classes with contract classes. 
Implementations references Interfaces and implements the abstract classes
Tests contains tests for the classes in Implementations

When the contracts reference assembly is built for Interfaces, the code coverage highlighting does not highlight the classes from Implementations, but rather from Interfaces, which is a problem. 
