using System.Collections.Generic;
using System.Linq;
using Protocols.Libs.Framework;

namespace Protocols.Libs.Models.Protocols
{
    public class ProtocolRepository
    {
        private MyContext _database = new MyContext();

        public List<Protocol> SelectAll()
        {
            return this._database.Protocol.ToList();
        }

        public Protocol SelectById(int id)
        {
            return this._database.Protocol.Find(id);
        }
    }
}
