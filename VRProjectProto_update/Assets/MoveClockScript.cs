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
        clock.transform.localPosition = new Vector3(-0.3034913f, clock.transform.localPosition.y, 0.04593123f);
        clock.transform.eulerAngles = new Vector3(clock.transform.eulerAngles.x, clock.transform.eulerAngles.y + 180f, clock.transform.eulerAngles.z);
        position = 0;
    }

    public static void RedRoomTriggerMove ()
    {
        if (position == 0 && allowedToMove)
        {
            clock.transform.localPosition = new Vector3(0.0535f, clock.transform.localPosition.y, 0.0463f);
            clock.transform.eulerAngles = new Vector3(clock.transform.eulerAngles.x, clock.transform.eulerAngles.y + 180f, clock.transform.eulerAngles.z);
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
            clock.transform.localPosition = new Vector3(0.0656f, clock.transform.localPosition.y, -0.0004f);
            clock.transform.eulerAngles = new Vector3(clock.transform.eulerAngles.x, clock.transform.eulerAngles.y + 180f, clock.transform.eulerAngles.z);
            allowedToMove = false;
            timer = 0;
            position = 2;
        }
    }

    public static void PictureFinishedMove ()
    {
        if (position == 2 && allowedToMove)
        {
            clock.transform.localPosition = new Vector3(0.3621f, clock.transform.localPosition.y, 0.0465f);
            clock.transform.eulerAngles = new Vector3(clock.transform.eulerAngles.x, clock.transform.eulerAngles.y + 180f, clock.transform.eulerAngles.z);
            allowedToMove = false;
            timer = 0;
            position = 3;
        }
    }

}
