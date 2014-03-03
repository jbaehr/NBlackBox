﻿using System;
using nblackbox.contract;

namespace nblackbox.internals
{
    internal class RecordedEvent : IRecordedEvent
    {
        public RecordedEvent(Guid id, DateTime timestamp, string name, string context, string data)
        {
            Id = id;
            Timestamp = timestamp;
            Name = name;
            Context = context;
            Data = data;
        }

        public Guid Id { get; private set; }
        public DateTime Timestamp { get; private set; }
        public string Name { get; private set; }
        public string Context { get; private set; }
        public string Data { get; private set; }
    }
}