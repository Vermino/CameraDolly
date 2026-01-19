namespace ACBindingsTest.Internal;

public unsafe struct LFQueue___AsyncCache_CAsyncRequest_ptr
{
    // Members
    public ACBindingsTest.Internal.AsyncCache.CAsyncRequest** buckets_;
    public int numBuckets_;
    public int m_dwProducerBucketIndex;
    public int m_dwConsumerBucketIndex;
    public ACBindingsTest.Internal.List___AsyncCache_CAsyncRequest_ptr m_backupList;
    public int m_dwBackupListLen;
    public ACBindingsTest.Internal.SharedCriticalSection m_backupListCritSec;

    // Methods
}

