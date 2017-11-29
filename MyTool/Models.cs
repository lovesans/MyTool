using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTool
{
    public enum MD5CrypType
    {
        md5pass,
        md5md5pass,
        md5dollarpassdotdollarsalt,
        md5dollarsaltdotdollarpass,
        md5md5dollarpassdotdollarsalt,
        md5md5dollarsaltdotdollarpass,
        md5dollarsaltdotdollarpassdotdollarsalt,
        md5dollarsaltdotmd5dollarpass,
        md5md5dollarpassdotmd5dollarsalt,
        md5md5dollarsaltdotmd5dollarpass
    }
    public enum MD5ReturnType
    {
        MD32大,
        MD32小,
        MD16大,
        MD16小,
        Base64
    }

}
