﻿/*
 Declare five variables choosing for each of them the most appropriate of the types 
 byte, sbyte, short, ushort, int, uint, long, ulong 
 to represent the following values: 
 52130, -115, 4825932, 97, -10000. 
 Choose a large enough type for each number to ensure it will fit in it. 
*/

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort first = 52130;
        sbyte second = -115;
        int third = 4825932;
        byte fourth = 97;
        short fifth = -10000;

        Console.WriteLine("{0} - ushort\ns{1} - byte\n{2} - int\n{3} - byte \n{4} - short"
                            , first, second, third, fourth, fifth);
    }
}