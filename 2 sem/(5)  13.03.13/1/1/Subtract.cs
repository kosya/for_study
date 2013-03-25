﻿using System;

namespace _1
{
    public class Subtract : Operation
    {
        public override int Action()
        {
            return Left.Action() - Right.Action();
        }

        public override void PrintOperation()
        {
            Console.Write('-');
        }
    }
}
