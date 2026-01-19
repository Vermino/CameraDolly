namespace ACBindingsTest.Internal;


/// <summary>
/// Handles asynchronous prefetch operations within the database cache, tracking pending contexts and preventing duplicate requests.
/// </summary>
/// <remarks>
/// Maintains a current prefetch context handle and a set of qualified data identifiers that have already been requested to ensure efficient cache loading and cleanup when fetches complete.
/// </remarks>
public unsafe struct DBCachePrefetchCallback
{
    // Base Classes
    public ACBindingsTest.Internal.AsyncCacheCallback BaseClass_AsyncCacheCallback; // ACBindingsTest.Internal.AsyncCacheCallback

    // Child Types
    public unsafe struct DBCachePrefetchCallback_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBCachePrefetchCallback*, ACBindingsTest.Internal.AsyncContext, ACBindingsTest.Internal.AsyncResult, uint, void> OnContextFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBCachePrefetchCallback*, ACBindingsTest.Internal.AsyncContext, ACBindingsTest.Internal.QualifiedDataID, ACBindingsTest.Internal.AsyncResult, uint, int, System.IntPtr, void> OnTopLevelRequestFinished; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.AsyncContext m_PreFetchContext;
    public ACBindingsTest.Internal.HashSet___QualifiedDataID m_hashRequestedIDs;

    // Methods

    /// <summary>Notifies the database cache that a prefetch operation has completed and clears the pending context.
    /// <code>Offset: 0x00414E50
    /// void __thiscall DBCachePrefetchCallback::OnContextFinished(DBCachePrefetchCallback*,AsyncContext,AsyncResult,unsigned int)</code>
    /// </summary>
    /// <param name="hContext">Handle to the asynchronous context associated with the prefetch request.</param>
    /// <param name="Result">Outcome of the asynchronous operation (success or error code).</param>
    /// <param name="dwUser1">User‑defined data passed through the callback; unused in this implementation.</param>
    public void OnContextFinished(ACBindingsTest.Internal.AsyncContext hContext, ACBindingsTest.Internal.AsyncResult Result, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DBCachePrefetchCallback, ACBindingsTest.Internal.AsyncContext, ACBindingsTest.Internal.AsyncResult, uint, void>)0x00414E50)(ref this, hContext, Result, dwUser1);

    /// <summary>Requests an asynchronous prefetch for the given data identifier if it has not already been requested.
    /// <code>Offset: 0x00414E90
    /// void __thiscall DBCachePrefetchCallback::PreFetch(DBCachePrefetchCallback*,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">Pointer to the QualifiedDataID that should be prefetched.</param>
    public void PreFetch(ACBindingsTest.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DBCachePrefetchCallback, ACBindingsTest.Internal.QualifiedDataID*, void>)0x00414E90)(ref this, qdid);

    /// <summary>Finalizes a top‑level prefetch request by removing its ID from the pending set when the operation completes once.
    /// <code>Offset: 0x00414F30
    /// void __thiscall DBCachePrefetchCallback::OnTopLevelRequestFinished(DBCachePrefetchCallback*,AsyncContext,QualifiedDataID,AsyncResult,unsigned int,int,void*)</code>
    /// </summary>
    /// <param name="hContext">The asynchronous context associated with the request.</param>
    /// <param name="qdid">Identifier of the data that was requested.</param>
    /// <param name="Result">Outcome status of the asynchronous fetch operation.</param>
    /// <param name="dwUser1">User‑defined value passed through the callback (not used in this method).</param>
    /// <param name="nTimesFinished">Number of times this callback has been invoked; cleanup occurs on first completion.</param>
    /// <param name="hInternal">Handle or state pointer provided by the caller for internal use.</param>
    public void OnTopLevelRequestFinished(ACBindingsTest.Internal.AsyncContext hContext, ACBindingsTest.Internal.QualifiedDataID qdid, ACBindingsTest.Internal.AsyncResult Result, uint dwUser1, int nTimesFinished, System.IntPtr hInternal) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DBCachePrefetchCallback, ACBindingsTest.Internal.AsyncContext, ACBindingsTest.Internal.QualifiedDataID, ACBindingsTest.Internal.AsyncResult, uint, int, System.IntPtr, void>)0x00414F30)(ref this, hContext, qdid, Result, dwUser1, nTimesFinished, hInternal);
}

