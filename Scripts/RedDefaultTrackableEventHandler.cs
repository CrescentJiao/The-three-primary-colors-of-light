
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.Rendering;
using Image = UnityEngine.UI.Image;

/// <summary>
///     A custom handler that implements the ITrackableEventHandler interface.
/// </summary>
public class RedDefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    public GameObject red;
    
    public GameObject wrong;

    #region PRIVATE_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;

    #endregion // PRIVATE_MEMBER_VARIABLES
    public static int redtrackID;
    #region UNTIY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        redtrackID = 0;
    }

    #endregion // UNTIY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            redtrackID = 1;
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NOT_FOUND)
        {
            redtrackID = 0;
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
            redtrackID = 0;
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PRIVATE_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);
                // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;
               // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;
                // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;
             
        red.GetComponent<Light>().enabled = true;
        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");

        if (mTrackableBehaviour.TrackableName.Equals("red"))
        {
            redtrackID = 1;
        }
        
    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);
        //var lightComponents = GetComponentInChildren<RenderingPath>(true);
        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;
        red.GetComponent<Light>().enabled = false ;
        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
        redtrackID = 0;
       // right.GetComponent<Text>().enabled = false;
    }

    #endregion // PRIVATE_METHODS
    void Update()
    {
        if (RedDefaultTrackableEventHandler.redtrackID == 1 && GreenDefaultTrackableEventHandler.greentrackID == 1)
        {
            wrong.GetComponent<Image>().enabled = false;
        }
        else if (RedDefaultTrackableEventHandler.redtrackID == 1 && BlueDefaultTrackableEventHandler.bluetrackID == 1)
        {
            wrong.GetComponent<Image>().enabled = true;
        }
        else if (GreenDefaultTrackableEventHandler.greentrackID == 1 && BlueDefaultTrackableEventHandler.bluetrackID == 1)
        {
            wrong.GetComponent<Image>().enabled = true;
        }
        else { wrong.GetComponent<Image>().enabled = false; }

    }
}