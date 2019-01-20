using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_BookTitles
{
    public class Book
    {
        string newsentence = "";
        public string Title {
            get
            {
                return newsentence;
            }
            set
            {
                string[] libary = new string[] { "a", "an", "and", "in", "of", "the" };
                string[] tempWord = value.Split(' ');

                for (int i = 0; i < tempWord.Length; i++)
                {
                    if (i == 0)
                    {
                        for (int k = 0; k < tempWord[0].Length; k++)
                        {
                            if (k == 0)
                            {
                                newsentence += tempWord[0].ToUpper()[0];
                            }
                            else
                            {
                                newsentence += tempWord[0][k];
                            }
                        }
                    }
                    else if (tempWord[i] == libary[0] || tempWord[i] == libary[1] || tempWord[i] == libary[2]
                         || tempWord[i] == libary[3] || tempWord[i] == libary[4] || tempWord[i] == libary[5])
                    {
                        newsentence += tempWord[i];
                    }
                    else
                    {
                        for (int k = 0; k < tempWord[i].Length; k++)
                        {
                            if (k == 0)
                            {
                                newsentence += tempWord[i].ToUpper()[0];
                            }
                            else
                            {
                                newsentence += tempWord[i][k];
                            }
                        }
                    }

                    if (i + 1 != tempWord.Length)
                    {
                        newsentence += " ";
                    }
                }
            }
        }
    }
}
