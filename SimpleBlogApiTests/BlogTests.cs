using System;
using Xunit;
using SimpleBlogApi.Models;


namespace SimpleBlogApiTests
{
    public class BlogTests
    {
        Post testPost;

        public BlogTests() {

        }

        [Theory]
        [InlineData("X4X8aJI1nD0S2z7lpPwaNjZB0nGPjrRW0IUabNNeeZ15tFMG4Y2axA9EsSjil4vpHBT1ju", "X4X8aJI1nD0S2z7lpPwaNjZB0nGPjrRW0IUabNNeeZ15tFMG4Y2axA9EsSjil4vpHBT1ju")]
        [InlineData("tksghm63r3QZjsDSCqaiEIAdW3tl2wzeT0fkyen5Wk2xCDhDzWMYU6ZO5bnHkcyRVbcodH", "tksghm63r3QZjsDSCqaiEIAdW3tl2wzeT0fkyen5Wk2xCDhDzWMYU6ZO5bnHkcyRVbcodHS")]        
        public void CheckLengthTest(string expected, string input)
        {
            testPost = new Post("123", input, "content", DateTime.Now);
            testPost.CheckTitleLength();
            Assert.Equal(expected, testPost.Title);
            Assert.Equal(expected.Length, testPost.Title.Length);
        }
        
//                 [Theory]
//         [InlineData("ee2bb24a-a272-4e3a-829f-19eb8a61a424", true)]
//         [InlineData("64a51443-13e3-4377-b565-b1f1e39c73b0", true)]
//         [InlineData("63ae9b96-e842-471d-aef3-bfbddebc19e8", true)]
//         [InlineData("63ae9b96e842471daef3bfbddebc19e8", false)]
//         [InlineData("ee2bb24a_a272_4e3a_829f_19eb8a61a424", false)]

//         public void CheckIdTest(string input, Boolean valid) {
//            testPost = new Post(input, "title", "content", DateTime.Now);
//            testPost.CheckId();
//            if(valid) {
//               Assert.Equal(input, testPost.Id);
//            } else {
//               Assert.NotEqual(input, testPost.Id);
//            }
//         }
        
        
    }
}
