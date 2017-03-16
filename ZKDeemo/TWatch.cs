namespace ZKDeemo
{
    #region Using

    using System;

    using ZooKeeperNet;

    #endregion

    public class TWatch : IWatcher
    {
        public void Process(WatchedEvent @event)
        {
            if (@event.Type == EventType.NodeDataChanged)
            {
                Console.WriteLine(@event.Path);
            }
        }
    }
}