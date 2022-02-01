﻿
using System;
using System.Collections.Generic;
namespace InterpreterDesignPattern
{
    public class Context
    {
        public string expression { get; set; }
        public DateTime date { get; set; }
        public Context(DateTime date)
        {
            this.date = date;
        }
    }
}
namespace InterpreterDesignPattern
{
    public interface AbstractExpression
    {
        void Evaluate(Context context);
    }
}
namespace InterpreterDesignPattern
{
    public class DayExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace("DD", context.date.Day.ToString());
        }
    }
}
namespace InterpreterDesignPattern
{
    public class MonthExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace("MM", context.date.Month.ToString());
        }
    }
}
namespace InterpreterDesignPattern
{
    class SeparatorExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace(" ", "-");
        }
    }
}

namespace InterpreterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractExpression> objExpressions = new List<AbstractExpression>();
            Context context = new Context(DateTime.Now);
            Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");

            context.expression = Console.ReadLine();
            string[] strArray = context.expression.Split(' ');

            foreach (var item in strArray)
            {
                if (item == "DD")
                {
                    objExpressions.Add(new DayExpression());
                }
                else if (item == "MM")
                {
                    objExpressions.Add(new MonthExpression());
                }
                else if (item == "YYYY")
                {
                    objExpressions.Add(new YearExpression());
                }
            }

            objExpressions.Add(new SeparatorExpression());
            foreach (var obj in objExpressions)
            {
                obj.Evaluate(context);
            }

            Console.WriteLine(context.expression);
            Console.Read();
        }
    }
}