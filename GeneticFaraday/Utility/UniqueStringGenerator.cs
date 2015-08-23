using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticFaraday.Utility
{
    public class UniqueStringGenerator
    {
        private char[] Chars { get; set; }
        private int maxCharValue { get; set; }
        private int minCharValue { get; set; }
        public UniqueStringGenerator()
            : this(97 /*'a'*/, 122)
        {
        }

        public UniqueStringGenerator(UniqueStringGenerator uniqueStringGenerator)
        {
            this.Chars = uniqueStringGenerator.Chars;
            this.maxCharValue = uniqueStringGenerator.maxCharValue;
            this.minCharValue = uniqueStringGenerator.minCharValue;
        }

        public UniqueStringGenerator(int minCharvalue, int maxCharValue)
        {
            this.minCharValue = minCharvalue;
            this.maxCharValue = maxCharValue;

            Chars = new char[1];
            Chars[0] = (char)(this.minCharValue - 1);
        }


        /// <summary>
        /// Moves the specified character in our chars array up by 1. If the uptick
        /// will set it over the max, sets the char back to the min value and goes
        /// to the next char in the array and upticks that one, etc.
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private char[] _moveCharAtIndexUp(char[] chars, int index)
        {
            // Up tick the char in the array if we can
            if (chars[index] < this.maxCharValue)
            {
                chars[index]++;

                return chars;
            }
            else
            {
                // If we get to the bottom of the array and the char still cannot be maxed
                // then set it to the min and add a "min char" to the end of the array.
                if (index == 0)
                {
                    chars[index] = (char)this.minCharValue;

                    char[] newCharArray = new char[chars.Length + 1];
                    for (int i = 0; i < chars.Length; i++)
                        newCharArray[i] = chars[i];

                    newCharArray[newCharArray.Length - 1] = (char)this.minCharValue;

                    return newCharArray;
                }
                // If tick will go higher than the max value, set it to the min value
                // and then go to the next closer char and up tick it
                else
                {
                    chars[index] = (char)this.minCharValue;

                    return _moveCharAtIndexUp(chars, index - 1);
                }

            }
        }

        public string GetNextString()
        {
            this.Chars = _moveCharAtIndexUp(this.Chars, this.Chars.Length - 1);
            return new string(this.Chars);
        }

        /// <summary>
        /// Sets the current string from which all future generated strings will increment.
        /// </summary>
        /// <param name="str"></param>
        public void SetCurrentString(string str)
        {
            this.Chars = str.ToCharArray();
        }
    }
}
