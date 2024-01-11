string[,] grid1 = new[,]
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};

WriteLine("{0} {1} {2} {3}",
    grid1.GetLowerBound(0),
    grid1.GetUpperBound(0),
    grid1.GetLowerBound(1),
    grid1.GetUpperBound(1)
);

WriteLine(grid1[0,0]);