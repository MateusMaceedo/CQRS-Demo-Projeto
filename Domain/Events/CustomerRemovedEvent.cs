using System;

namespace Domain.Events
{
    public class CustomerRemovedEvent
    {
        public CustomerRemovedEvent(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
