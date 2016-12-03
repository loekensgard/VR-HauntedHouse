using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClockScript : MonoBehaviour {
    public static int position = 0;
    static GameObject clock;
    static float timer = 0;
    static bool allowedToMove = true;

    void Start()
    {
        clock = gameObject;
    }

    void Update ()
    {
        if (!allowedToMove)
            timer += Time.deltaTime;

        if (timer >= 20f)
            allowedToMove = true;
    }

    // original location
    static void OriginalPositionMove()
    {
        clock.transform.localPosition = new Vector3(-0.2843f, clock.transform.localPosition.y, 0.04593123f);
        clock.transform.eulerAngles = new Vector3(clock.transform.eulerAngles.x, -270f, clock.transform.eulerAngles.z);
        position = 0;
    }

    public static void RedRoomTriggerMove ()
    {
        if (position == 0 && allowedToMove)
        {
            clock.transform.localPosition = new Vector3(0.0329f, clock.transform.localPosition.y, 0.0318f);
            clock.transform.eulerAngles = new Vector3(clock.transform.eulerAngles.x, -90f, clock.transform.eulerAngles.z);
            allowedToMove = false;
            timer = 0;
            position = 1;
        }
    }

    // redrom location
    public static void LookingAtStairsMove()
    {
        if (position == 1 && allowedToMove)
        {
            clock.transform.localPosition = new Vector3(0.0871f, clock.transform.localPosition.y, -0.0122f);
            clock.transform.eulerAngles = new Vector3(clock.transform.eulerAngles.x, -270f, clock.transform.eulerAngles.z);
            allowedToMove = false;
            timer = 0;
            position = 2;
        }
    }

    public static void PictureFinishedMove ()
    {
        if (position == 2 && allowedToMove)
        {
            clock.transform.localPosition = new Vector3(0.3401f, clock.transform.localPosition.y, -0.0023f);
            clock.transform.eulerAngles = new Vector3(clock.transform.eulerAngles.x, -90f, clock.transform.eulerAngles.z);
            allowedToMove = false;
            timer = 0;
            position = 3;
        }
    }

}
