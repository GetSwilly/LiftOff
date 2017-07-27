using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff
{
    public class Vault
    {
        Dictionary<string, object> m_Storage;

        public Vault(params Tuple<string,object>[] storageObjects)
        {
            m_Storage = new Dictionary<string, object>();
            

            for(int i = 0; i < storageObjects.Length; i++)
            {
                Store(storageObjects[i]);
            }
        }


        public void Store(Tuple<string, object> storeTuple)
        {
            Store(storeTuple.Item1, storeTuple.Item2);
        }
        public void Store(string id, object obj)
        {
            if (id == null || string.IsNullOrEmpty(id) || obj == null)
                return;

            m_Storage.Add(id, obj);
        }

        public object Retrieve(string id)
        {
            if (id == null || string.IsNullOrEmpty(id))
                return null;

            return m_Storage[id];
        }
    }
}
