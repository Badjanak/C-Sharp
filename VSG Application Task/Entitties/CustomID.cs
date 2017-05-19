using System;

namespace Entities
{
    public class CustomID
    {
        private readonly Guid _id;

        public CustomID()
        {
            this._id = Guid.NewGuid();
        }

        public CustomID(Guid guid)
        {
            this._id = guid;
        }

        public override string ToString()
        {
            return this._id.ToString();
        }
    }
}
