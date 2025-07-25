﻿using BuilderSample.Builders;
using BuilderSample.Directors;

var director = new HouseDirector();

var normalHouseBuilder = new NormalHouseBuilder();
var normalHouse = director.BuildHouse(normalHouseBuilder);
normalHouse.PrintHouseInfo();
Console.WriteLine("======================================");
var fancyHouseBuilder = new FancyHouseBuilder();
var fancyHouse = director.BuildHouse(fancyHouseBuilder);
fancyHouse.PrintHouseInfo();
