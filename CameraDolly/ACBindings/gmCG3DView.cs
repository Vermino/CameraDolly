namespace ACBindingsTest.Internal;


/// <summary>Manages a 3‑D preview of the character being designed, handling viewport association, player physics object creation, animation selection, camera positioning, and background environment updates.</summary>
public unsafe struct gmCG3DView
{
    // Members
    public ACBindingsTest.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindingsTest.Internal.UIElement_Viewport* m_pViewport;
    public ACBindingsTest.Internal.CPhysicsObj* m_pPlayerObject;
    public ACBindingsTest.Internal.CPhysicsObj* m_pbgObject;
    public ACBindingsTest.Internal.IDClass____tagDataID m_didAnimation;
    public ACBindingsTest.Internal.IDClass____tagDataID m_didAnimationRest;
    public fixed byte m_didAnimArray_Raw[20];
    public ACBindingsTest.Internal.IDClass____tagDataID* m_didAnimArray => (ACBindingsTest.Internal.IDClass____tagDataID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_didAnimArray_Raw[0]);
    public double m_dLastAnimTime;
    public ACBindingsTest.Internal.IDClass____tagDataID m_bgSetupID;
    public ACBindingsTest.Internal.IDClass____tagDataID m_alternateSetupID;
    public float m_fHeading;
    public ACBindingsTest.Internal.IDClass____tagDataID m_SetupID;
    public ACBindingsTest.Internal.Vector3 m_vectPosition;
    public ACBindingsTest.Internal.Vector3 m_vectDirection;

    // Generated Constructor
    public gmCG3DView() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Sets the player's heading to the specified value and updates the underlying physics object accordingly.
    /// <code>Offset: 0x004EF220
    /// void __thiscall gmCG3DView::SetPlayerHeading(gmCG3DView*,float)</code>
    /// </summary>
    /// <param name="fHeading">The desired heading for the player.</param>
    public void SetPlayerHeading(float fHeading) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCG3DView, float, void>)0x004EF220)(ref this, fHeading);

    /// <summary>Configures the camera’s position and direction within the 3‑D view.
    /// <code>Offset: 0x004EF240
    /// void __thiscall gmCG3DView::SetCamera(gmCG3DView*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="vectPosition">The desired camera position as a vector.</param>
    /// <param name="vectDirection">The desired viewing direction as a vector.</param>
    public void SetCamera(ACBindingsTest.Internal.AC1Legacy.Vector3* vectPosition, ACBindingsTest.Internal.AC1Legacy.Vector3* vectDirection) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCG3DView, ACBindingsTest.Internal.AC1Legacy.Vector3*, ACBindingsTest.Internal.AC1Legacy.Vector3*, void>)0x004EF240)(ref this, vectPosition, vectDirection);

    /// <summary>Clears previous animations on the player object and initiates a new animation sequence defined by m_didAnimation, resetting the last animation timestamp to the current time.
    /// <code>Offset: 0x004EF290
    /// void __thiscall gmCG3DView::StartAnimation(gmCG3DView*)</code>
    /// </summary>
    public void StartAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCG3DView, void>)0x004EF290)(ref this);

    /// <summary>Stops any active animation on the player object and restores it to its default resting pose.
    /// <code>Offset: 0x004EF2D0
    /// void __thiscall gmCG3DView::StopAnimation(gmCG3DView*)</code>
    /// </summary>
    public void StopAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCG3DView, void>)0x004EF2D0)(ref this);

    /// <summary>Initializes a gmCG3DView instance by clearing viewport and object references, resetting heading and direction vectors, and loading predefined animation identifiers from the database.
    /// <code>Offset: 0x004EF310
    /// void __thiscall gmCG3DView::gmCG3DView(gmCG3DView*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCG3DView, void>)0x004EF310)(ref this);

    /// <summary>Initializes the 3D view with a viewport, retrieves player system and character generation state, creates the appropriate player physics object based on heritage group, loads associated animation identifiers from the database, and activates sharp mode rendering.
    /// <code>Offset: 0x004EF3F0
    /// void __thiscall gmCG3DView::Initialize(gmCG3DView*,UIElement_Viewport*)</code>
    /// </summary>
    /// <param name="pViewport">The UIElement_Viewport to associate with this view.</param>
    public void Initialize(ACBindingsTest.Internal.UIElement_Viewport* pViewport) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCG3DView, ACBindingsTest.Internal.UIElement_Viewport*, void>)0x004EF3F0)(ref this, pViewport);

    /// <summary>Refreshes the character preview view by applying the current generation settings, updating the model, animations, clothing, colors, lighting and camera position.
    /// <code>Offset: 0x004EF660
    /// void __thiscall gmCG3DView::Update(gmCG3DView*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCG3DView, void>)0x004EF660)(ref this);
}

