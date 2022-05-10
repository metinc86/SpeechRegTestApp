using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechRegTestApp
{
    public class RandomNumberCreater
    {
        public int ValueCreator(int min, int max)
        { 
            Random random = new Random();
            int result = random.Next(min, max);
            return result; 
        }
    }
}
