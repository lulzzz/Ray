﻿using Ray.Core.Snapshot;
using RayTest.IGrains.Events;
using RayTest.IGrains.States;

namespace RayTest.Grains
{
    public class SnapshotHandler : SnapshotHandler<long, AccountState>
    {
        public void AmountTransferEventHandle(AccountState state, AmountTransferEvent evt)
        {
            state.Balance = evt.Balance;
        }
        public void AmountAddEventHandle(AccountState state, AmountAddEvent evt)
        {
            state.Balance += evt.Amount;
        }
    }
}
