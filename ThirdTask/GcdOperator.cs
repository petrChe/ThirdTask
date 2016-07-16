using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ThirdTask
{
    class GcdOperator
    {
        public int firstNumber;
        public int secondNumber;
        public int thirdNumber;

        public GcdOperator() { }
        public GcdOperator(int firstNum, int secondNum)
        {
            this.firstNumber = firstNum;
            this.secondNumber = secondNum;
        }
        public GcdOperator(int firstNum, int secondNum, int thirdNum)
        {
            this.firstNumber = firstNum;
            this.secondNumber = secondNum;
            this.thirdNumber = thirdNum;
        }

        public int FindEuclidGcd(int firstNum, int secondNum)
        {
            int gcd = 0;
            int maxNum = firstNum;
            int minNum = secondNum;
            if (maxNum < secondNum && minNum > firstNum)
            {
                maxNum = secondNum;
                minNum = firstNum;
            }

            while (maxNum != minNum)
            {
                if (maxNum == 0)
                {
                    gcd = minNum;
                    break;
                }
                else if (minNum == 0)
                {
                    gcd = maxNum;
                    break;
                }
                else if (maxNum % minNum == 0)
                {
                    gcd = minNum;
                    break;
                }
                else
                {
                    int rest = maxNum % minNum;
                    maxNum = minNum;
                    minNum = rest;

                }
            }
            if (maxNum == minNum)
            {
                gcd = maxNum;
            }
            return gcd;
        }


        public int FindEuclidGcd(int firstNum, int secondNum, int thirdNum, out long milleseconds)
        {
            Stopwatch watch = Stopwatch.StartNew();
            int firstNod = FindEuclidGcd(firstNum, secondNum);
            int gcd = 0;
            int maxNum = secondNum;
            int minNum = thirdNum;
            if (maxNum < thirdNum && minNum > secondNum)
            {
                maxNum = thirdNum;
                minNum = secondNum;
            }
            while (maxNum != minNum)
            {
                if (maxNum % minNum == 0)
                {
                    gcd = minNum;
                    break;
                }
                else
                {
                    int rest = maxNum % minNum;
                    maxNum = minNum;
                    minNum = rest;

                }
            }
            watch.Stop();
            milleseconds = watch.ElapsedMilliseconds;
            return gcd;
        }

        public int FindBinaryGcd(int firstNum, int secondNum, out long milliseconds)
        {
            Stopwatch watch = Stopwatch.StartNew();
            int gcd = 0;
            int count = 1;
            while (firstNum != 0 && secondNum != 0)
            {
                if (CheckParity(firstNum) && CheckParity(secondNum))
                {
                    while (!CheckParity(firstNum) || !CheckParity(secondNum))
                    {
                        firstNum /= 2;
                        secondNum /= 2;
                        count *= 2;

                    }
                }
                if (CheckParity(firstNum) && !CheckParity(secondNum))
                {
                    while (firstNum % 2 == 0)
                    {
                        firstNum /= 2;
                    }
                }
                if (!CheckParity(firstNum) && CheckParity(secondNum))
                {
                    while (secondNum % 2 == 0)
                    {
                        secondNum /= 2;
                    }
                }
                if (firstNum >= secondNum)
                {
                    firstNum = firstNum - secondNum;
                }
                else
                {
                    secondNum = secondNum - firstNum;
                }

            }
            gcd = secondNum * count;
            watch.Stop();
            milliseconds = watch.ElapsedMilliseconds;
            return gcd;
        }

        public bool CheckParity(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

