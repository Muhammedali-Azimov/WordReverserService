using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WordReverserService.Controllers
{
    public class WordReverserController : ApiController
    {

        // POST: api/WordReverser
        public string[] Post([FromBody] string[] value)
        {
            List<string> reversedList = new List<string>();

            foreach (var item in value)
            {
                char[] charArray = item.ToCharArray();
                Array.Reverse(charArray);
                string reversedItem = new string(charArray);
                reversedList.Add(reversedItem);
            }
            string[] reversedArray = reversedList.ToArray();

            return reversedArray;
        }


    }
}
