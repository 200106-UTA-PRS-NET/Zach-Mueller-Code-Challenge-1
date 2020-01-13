using System;
using Xunit;
using Palindrome;


namespace PalindromeTest
{
    public class UnitTest1
    {
        [Fact]
        public void WhiteSpace()
        {
            string sample = "soon noos";
            sample = sample.Replace(" ", string.Empty);
            Assert.Equal("Soonnoos", sample);
        }

        public void ReverseTest()
        {
            string sample = "soon, noos";
            Palindrome.Palindrome.Palin(sample);

            Assert.Equal("soonnoos", sample);
          
        }
    
                    
            
    
        }
    }

