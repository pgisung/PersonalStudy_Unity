using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    interface ITask
    {
        void Execute();
    }

    class BroadcastTask : ITask
    {
        GameRoom _room;
        ClientSession _session;
        string _chat;

        BroadcastTask(GameRoom room, ClientSession session, string chat)
        {
            _room = room;
            _session = session;
            _chat = chat;
        }

        public void Execute()
        {
            _room.Broadcast(_session, _chat);
        }
    }

    // 람다 표현식을 이용한 JobQueue를 이용하지 않을 경우 가능한 방법 중 하나 실행할 함수마다 class로 작성하여 처리
    internal class TaskQueue
    {
        Queue<ITask> _queue = new Queue<ITask>();
    }
}
