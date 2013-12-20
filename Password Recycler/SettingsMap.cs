using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SettingsMap
{
    public class SettingsMap
    {
        public String Name { get; set; }
        public String BaseDN { get; set; }
        public String DomainController { get; set; }
    }
    public class SettingsMapCollection : BindingList<SettingsMap>
    {
        public SettingsMapCollection Clone()
        {
            SettingsMapCollection result = new SettingsMapCollection();

            foreach (SettingsMap map in this)
                result.Add(new SettingsMap()
                {
                    Name = map.Name,
                    BaseDN = map.BaseDN,
                    DomainController = map.DomainController
                });
            return result;
        }
    }
}
