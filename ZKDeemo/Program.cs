using System.Collections;
namespace ZKDeemo
{
    #region Using

    using System;

    using ZooKeeperNet;

    #endregion

    internal class Program
    {
        private static void Main(string[] args)
        {
            using (ZooKeeper zk = new ZooKeeper("127.0.0.1:2181", new TimeSpan(0, 0, 0, 5000), new TWatch()))
            {

                var stat = zk.Exists("/root", true);

                var stat2 = zk.Exists("/root/childone", true);

                var childs = zk.GetChildren("/root", false);

                //zk.Create("/root/lz", "/root/lz".GetBytes(), Ids.OPEN_ACL_UNSAFE, CreateMode.Persistent);

                //zk.Create("/root/childone", "/root/childone".GetBytes(), Ids.OPEN_ACL_UNSAFE, CreateMode.Persistent);

                //zk.GetChildren("/root", true);

                //zk.GetData("/root", true, null);

                //zk.SetData("/root/childone", "childonemodify".GetBytes(), -1);

                //zk.Delete("/root/lz", -1);
            }

            Console.ReadLine();
        }
    }
}