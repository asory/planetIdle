using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public float maxZoom = 55f;
    public float minZoom = 5f;
    public float zoomSpeed = 5f;
    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        HandleZoom();
    }

    public void HandleZoom()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 || Input.GetAxis("Mouse ScrollWheel") < 0)
        {

            camera.fieldOfView += zoomSpeed * Input.GetAxis("Mouse ScrollWheel");

            camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, minZoom, maxZoom);

        }

    }
}