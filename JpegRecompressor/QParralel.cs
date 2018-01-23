using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JpegRecompressor
{
    public static class QParallel
    {
        public static void For(int start, int end, int threadCount, Action<int> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            var position = start;
            var threads = new List<Task>();

            while (position < end)
            {
                var position1 = position;
                var th = Task.Factory.StartNew(() => { action.Invoke(position1); });
                threads.Add(th);

                if (threads.Count >= threadCount)
                {
                    Task.WaitAny(threads.ToArray());
                    threads.RemoveAll(x => x.IsCompleted);
                }

                position++;
            }

            Task.WaitAll(threads.ToArray());
        }

        public static void ForEach<T>(IEnumerable<T> collection, int threadCount, Action<T> action)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            var threads = new List<Task>();
            using (var enumerator = collection.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var item = enumerator.Current;
                    var th = Task.Factory.StartNew(() => { action.Invoke(item); });
                    threads.Add(th);

                    if (threads.Count >= threadCount)
                    {
                        Task.WaitAny(threads.ToArray());
                        threads.RemoveAll(x => x.IsCompleted);
                    }
                }

                Task.WaitAll(threads.ToArray());
            }
        }
    }
}
