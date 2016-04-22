using UnityEngine;
using System.Collections;

public class DualCamera : MonoBehaviour {

    public Camera myTopDown;
    public bool isTopDownShowing;

	// Use this for initialization
	void Start () {

        updatecam();
	}
	
    void updatecam()
    {
        myTopDown.enabled = isTopDownShowing;
        UnityEngine.VR.VRSettings.showDeviceView = !isTopDownShowing;
    
    }

	void Update () {
	    if (Input.GetKeyDown(KeyCode.V) )
        {
                    isTopDownShowing = !isTopDownShowing;
            updatecam ();
        }
	}
}
