using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class logScript : MonoBehaviour {

    static bool fly;
    public static ArrayList logs;
    float rand = 0f;

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static void AddLog(GameObject log)
    {
        if (logs == null)
            logs = new ArrayList();
        logs.Add(log);
    }


    // Use this for initialization
    void Start () {
        AddLog(gameObject);
        rand = Random.Range(1.1f, 1.5f);

    }
	
	// Update is called once per frame
	void Update () {
        if (fly)
        {
            if (gameObject.GetComponent<Rigidbody>().transform.localPosition.y >= 1.866f)
            {
                Destroy(gameObject);
            }else{
                GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.up) * (rand * Mathf.Abs(Physics.gravity.y)));
            }
            
        }
    }

    public void Fly()
    {
        if (!fly)
        {
            fly = true;
        }
    }
}
