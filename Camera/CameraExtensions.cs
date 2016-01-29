using UnityEngine;
using System.Collections;

public static class CameraExtensions {

    public static Vector3 MouseWorldPoint(this Camera camera)
    {
        Vector3 mp = Input.mousePosition;
        mp.z = -camera.transform.position.z;
        return camera.ScreenToWorldPoint(mp);
    }
}
