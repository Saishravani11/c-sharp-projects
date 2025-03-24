using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDesignPattern
{
    internal class Builder
    {
        private Mobile _mobile= new Mobile();
        public Builder setStorage(string storage)
        {
            _mobile.storage=storage;
            return this;

        }
        public Builder setos(string os)
        {
            _mobile.os = os;
            return this;
        }
        public Mobile Build()
        {
            return _mobile;

        }
    }
}
