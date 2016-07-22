using System;

namespace GUIDgenerator
{
    public class GuidFactory : IGuidFactory
    {
        public Guid getGuid()
        {
            Guid freshGuid =  Guid.NewGuid();
            return freshGuid;
        }
    }
}