using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_1_OOP
{
    class Calculator : ICalculator
    {
        public int AND(int a, int b)
        {
            try
            {
                return a & b;
            }
            catch(Exception e)
            {
                Console.WriteLine("was exception - ", nameof(e));
            }
            finally
            {
            
            }
            return 0;
        }

        public int NOT(int a)
        {
            try
            {
                return ~a;
            }
            catch (Exception e)
            {
                Console.WriteLine("was exception - ", nameof(e));
            }
            finally
            {

            }
            return 0;
        }

        public int OR(int a, int b)
        {
            try
            {
                return a | b;
            }
            catch (Exception e)
            {
                Console.WriteLine("was exception - ", nameof(e));
            }
            finally
            {
                
            }
            return 0;
        }

        public int XOR(int a, int b)
        {
            try
            {
                return a ^ b;
            }
            catch(Exception e)
            {
                Console.WriteLine("was exception - ", nameof(e));
            }
            finally
            {

            }
            return 0;
        }
    }
}
