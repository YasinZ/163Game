// iOS gyroscope example
//
// Create a cube with camera vector names on the faces.
// Allow the iPhone to show named faces as it is oriented.

using UnityEngine;
using UnityEngine.iOS;

public class Movement : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        gyroEnabled = EnableGyro();
       // Debug.Log(gyroEnabled);
    }

    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            return true;
        }

        return false;
    }

    private void Update()
    {
        if(gyroEnabled)
        {
            Debug.Log(gyro.attitude);
            //Debug.Log(-1 * Vector3.right);
            //Debug.Log(gyro.rotationRate.y);
            if(gyro.attitude.y < -.1f)
                GetComponent<Rigidbody>().AddForce(Vector3.right * 20);
            else if((gyro.attitude.y > .1f))
                GetComponent<Rigidbody>().AddForce(Vector3.left * 20);

            //GetComponent<Rigidbody>().AddForce(Vector3.forward * 5);
            //GetComponent<Rigidbody>().MovePosition(Vector3.forward);
            //transform.Translate(Vector3.forward);
        }
        //GetComponent<Rigidbody>().AddForce(Vector3.forward * 10);
    }
}