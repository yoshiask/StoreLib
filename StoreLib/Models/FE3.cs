using System;

namespace StoreLib.Models
{
    public class PackageInstance : IComparable<PackageInstance>
    {
        public string PackageMoniker;
        public Uri PackageUri;
        public PackageType PackageType;
        public string Digest;

        public PackageInstance(string PackageMoniker, Uri PackageUri, PackageType packageType, string digest)
        {
            this.PackageMoniker = PackageMoniker;
            this.PackageUri = PackageUri;
            this.PackageType = packageType;
            this.Digest = digest;
        }

        public string PackageFamily
        {
            get
            {
                try
                {
                    return PackageMoniker.Split('_')[0];
                }
                catch { return null; }
            }
        }

        public Version Version
        {
            get
            {
                try
                {
                    return new Version(PackageMoniker.Split('_')[1]);
                }
                catch { return null; }
            }
        }

        public string Architecture
        {
            get
            {
                try
                {
                    return PackageMoniker.Split('_')[2];
                }
                catch { return null; }
            }
        }

        public string PublisherId
        {
            get
            {
                try
                {
                    var parts = PackageMoniker.Split('_');
                    return parts[parts.Length - 1];
                }
                catch { return null; }
            }
        }

        int IComparable<PackageInstance>.CompareTo(PackageInstance other)
        {
            return Version.CompareTo(other.Version);
        }
    }
}
