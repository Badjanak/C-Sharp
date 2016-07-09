using System;
using System.Text;

class DifferentIntegersSize
{
    static void Main()
    {
        string n = Console.ReadLine();
        StringBuilder output = new StringBuilder();

        sbyte sbyteCheck;
        byte byteCheck;
        short shortCheck;
        ushort ushortCheck;
        int intCheck;
        uint uintCheck;
        long longCheck;

        bool canFit = long.TryParse(n, out longCheck);
        output.Append(n);

        if (canFit)
        {
            output.AppendLine(" can fit in:");
        }
        else
        {
            output.AppendLine(" can't fit in any type");
            Console.WriteLine(output);
            return;
        }

        if (sbyte.TryParse(n, out sbyteCheck))
        {
            output.AppendLine("* sbyte");
        }
        if (byte.TryParse(n, out byteCheck))
        {
            output.AppendLine("* byte");
        }
        if (short.TryParse(n, out shortCheck))
        {
            output.AppendLine("* short");
        }
        if (ushort.TryParse(n, out ushortCheck))
        {
            output.AppendLine("* ushort");
        }
        if (int.TryParse(n, out intCheck))
        {
            output.AppendLine("* int");
        }
        if (uint.TryParse(n, out uintCheck))
        {
            output.AppendLine("* uint");
        }
        if (long.TryParse(n, out longCheck))
        {
            output.AppendLine("* long");
        }
        Console.WriteLine(output);
    }
}