
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.Rendering;

/// <summary>
///     A custom handler that implements the ITrackableEventHandler interface.
/// </summary>
public class quesiton1 : MonoBehaviour, ITrackableEventHandler
{
    public GameObject red;
    public GameObject green;
    public GameObject right;
   
    //right.Find(“Canvas”).GetComponent(UI.Text).text=”right”;
    // right.Find("Canvas/Text").GetComponent<UnityEngine.UI.Text>().text = ”right”;
    #region PRIVATE_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;

    #endregion // PRIVATE_MEMBER_VARIABLES

    #region UNTIY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
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
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NOT_FOUND)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
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
        Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
      /* if (mTrackableBehaviour.TrackableName == "red" && mTrackableBehaviour.TrackableName == "green")
        {   right.GetComponent<Text>().enabled = true;      }
        else   {
          right.GetComponent<Text>().enabled = false;
        }*/
        if(RedDefaultTrackableEventHandler. redtrackID==1 && GreenDefaultTrackableEventHandler.greentrackID == 1)
         {
             right.GetComponent<Text>().enabled = true;
         }
         else
         {
             right.GetComponent<Text>().enabled = false;
         }

    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;
        right.GetComponent<Text>().enabled = false;

    }

    #endregion // PRIVATE_METHODS
   /* private void Update()
    {
        if ((red.GetComponent<Light>().enabled = true) &&(green.GetComponent<Light>().enabled = true))
            {
            right.GetComponent<Text>().enabled = true;
        }
        else
        {
            right.GetComponent<Text>().enabled = false;
        }
    }*/
}