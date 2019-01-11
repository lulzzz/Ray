﻿namespace Ray.Core.Event
{
    public class EventSaveWrapper<K>
    {
        public EventSaveWrapper(IActorEvent<K> evt, byte[] bytes, string uniqueId = null)
        {
            Event = evt;
            UniqueId = uniqueId;
            Bytes = bytes;
        }
        public IActorEvent<K> Event { get; set; }
        public string UniqueId { get; set; }
        public byte[] Bytes { get; set; }
        public bool ReturnValue { get; set; }
    }
}