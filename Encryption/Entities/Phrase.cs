using System;
using Encryption.Interface;

namespace Encryption.Entities
{
    public class Phrase : ICheck
    {
        public string Text { get; set; }
        public Phrase() { }
        public Phrase(string text)
        {
            this.Text = text;
        }

        public String RemoveWhiteSpaces(String phrase)
        {
            string letter = String.Empty;
            string newPhrase = String.Empty;

            if(phrase == null)
            {
                throw new ArgumentNullException("No Argument given");
            }
            else
            {
                foreach (char l in phrase)
                {
                    if (l == ' ')
                    {
                        letter = String.Empty;
                    }
                    else
                    {
                        letter = l.ToString();
                    }

                    newPhrase += letter;
                }

                return newPhrase;
            }

        }

    }
}
