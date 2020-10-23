using System;
using System.Text;

namespace P3Lab3
{
    public class SentenceCorrector
    {
        private StringBuilder builder;
        private string sentence;
        public SentenceCorrector(string sentence)
        {
            builder = new StringBuilder();
            this.sentence = sentence;
        }

        public string correctSentence()
        {
            
            builder.Append(char.ToUpper(sentence[0]));

            if (!sentence.EndsWith('.'))
            {
                builder.Append(sentence.Substring(1));
                builder.Append(".");
            }
                
            else
            {
                builder.Append(sentence.Substring(1));
            }


            return builder.ToString();
        }


    }
}