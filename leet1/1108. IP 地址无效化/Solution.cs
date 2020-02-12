using System;
using System.Collections.Generic;
using System.Text;

namespace leet1._1108._IP_地址无效化
{
    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
