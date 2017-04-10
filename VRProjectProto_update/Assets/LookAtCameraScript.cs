using UnityEngine;

public class LookAtCameraScript : MonoBehaviour {
    public float x;
    public float y;
    public float z;

    void Update()
    {
        Vector3 relativePos = Camera.main.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        rotation.x = 0;
        rotation.z = 0;
        rotation *= Quaternion.Euler(new Vector3(x, y, z));
        transform.rotation = rotation;
    }
}
