using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class LambdaExamples
    {
        delegate int del(int value);

        public int MyLambdaOne(int val)
        {
            //(input-paramerters)=> expression-or-statement-block
            del myDelegate = x => x * x;
            return myDelegate(val);

        }
    }
}
