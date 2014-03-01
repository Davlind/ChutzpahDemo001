namespace ChutzpahDemo001.Controllers
{
    using System;
    using System.Web.Http;

    public class LevenshteinController : ApiController
    {
        // GET api/values/5
        public int Get(string value1, string value2)
        {
            var value1Length = value1.Length;
            var value2Length = value2.Length;
            var diffArray = new int[value1Length + 1, value2Length + 1];

            for (var i = 0; i <= value1Length; diffArray[i, 0] = i++)
            {
            }

            for (var j = 0; j <= value2Length; diffArray[0, j] = j++)
            {
            }

            for (var i = 1; i <= value1Length; i++)
            {
                for (var j = 1; j <= value2Length; j++)
                {
                    var cost = (value2[j - 1] == value1[i - 1]) ? 0 : 1;

                    diffArray[i, j] = Math.Min(
                        Math.Min(diffArray[i - 1, j] + 1, diffArray[i, j - 1] + 1),
                        diffArray[i - 1, j - 1] + cost);
                }
            }
            return diffArray[value1Length, value2Length];
        }
    }
}
