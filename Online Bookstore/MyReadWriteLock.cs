using System;

public class MyReadWriteLock
{
	public MyReadWriteLock()
    {
        private int waitingForReadLock = 0; // number of theads waiting to get access to read
        private Thread writeLockedThread = null; // the thread that is writing and so has the lock
        private int outstandingReadLocks = 0; // number of threads currently reading
        private ArrayList waitingforWriteLock = new ArrayList(); // list of threads waiting to write

        public void readLock()
        {
            lock (this)
            {
                if (writeLockedThread != null)
                {
                    waitingForReadLock++;
                    while (writeLockedThread != null)
                    {
                        Monitor.Wait(this);
                    }
                    waitingForReadLock--;
                }
                outstandingReadLocks++;
            }
        }

        public void writeLock()
        {
            Thread tryingThread; // the thread currently trying to get the lock

            lock (this)
            {
                // when there is no thread writing and no threads currently reading
                if (writeLockedThread == null && outstandingReadLocks == 0)
                {
                    writeLockedThread = Thread.CurrentThread; // set this thread to be the writeLockedThread
                    return;
                }
                tryingThread = Thread.CurrentThread; // set the thread trying to get the lock to this thread
                waitingforWriteLock.Add(tryingThread); // add the thread trying to write to the list
            }

            lock (tryingThread)
            {
                while (tryingThread != writeLockedThread) // wait until this thread has the lock
                {
                    Monitor.Wait(tryingThread);
                }
            }

            lock (this)
            {
                waitingforWriteLock.Remove(tryingThread); // once this thread has the lock, remove it from the list
            }
        }

        public void done()
        {
            lock (this)
            {
                if (outstandingReadLocks > 0) // there are threads reading
                {
                    outstandingReadLocks--;
                    if (outstandingReadLocks == 0 && waitingforWriteLock.Count > 0) // there are no threads reading and there are threads waiting to write
                    {
                        writeLockedThread = (Thread)waitingforWriteLock[0]; // give the lock to a waiting thread

                        lock (writeLockedThread) // wake all threads waiting on the write lock thread ?
                        {
                            Monitor.PulseAll(writeLockedThread);
                        }
                    }
                }
                else if (Thread.CurrentThread == writeLockedThread) // this thread has the lock
                {
                    if (outstandingReadLocks == 0 && waitingforWriteLock.Count > 0) // no threads reading and there are threads waiting to write
                    {
                        writeLockedThread = (Thread)waitingforWriteLock[0];

                        lock (writeLockedThread)
                        {
                            Monitor.PulseAll(writeLockedThread);
                        }
                    }
                    else
                    {
                        writeLockedThread = null;
                        if (waitingForReadLock > 0) // wake all threads waiting to read
                        {
                            Monitor.PulseAll(this);
                        }
                    }
                }
            }
        }
    }


}
