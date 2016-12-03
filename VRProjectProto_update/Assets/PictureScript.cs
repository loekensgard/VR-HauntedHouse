using System.Collections;
using UnityEngine;

public class PictureScript: MonoBehaviour {
	public GameObject piece1;
	public GameObject piece2;
	public GameObject piece3;
	public GameObject piece4;
	public GameObject piece5;
    public GameObject kamera;

    static bool StartFlashing;

	int piecesFound;

	// Use this for initialization
	void Start () {
		piece1.GetComponent<Renderer> ().enabled = false;
		piece2.GetComponent<Renderer> ().enabled = false;
		piece3.GetComponent<Renderer> ().enabled = false;
		piece4.GetComponent<Renderer> ().enabled = false;
		piece5.GetComponent<Renderer> ().enabled = false;
		piecesFound = 0;
	}

    public void Update ()
    {
        if (StartFlashing)
        {
            StartFlashing = false;
            StartCoroutine(FlashSequence());
        }
    }
	
	public void FindPiece (int piece)
	{
		piecesFound++;
        switch (piece)
        {
            case 1:
                piece1.GetComponent<Renderer>().enabled = true;
                break;
            case 2:
                piece2.GetComponent<Renderer>().enabled = true;
                break;
            case 3:
                piece3.GetComponent<Renderer>().enabled = true;
                break;
            case 4:
                piece4.GetComponent<Renderer>().enabled = true;
                break;
            case 5:
                piece5.GetComponent<Renderer>().enabled = true;
                break;
            default:
                break;
        }
        if (piecesFound == 5)
            EndSequence();
        gameObject.GetComponent<AudioSource>().Play();
	}


	void EndSequence () {
        MoveClockScript.PictureFinishedMove();
        ClockScript.thisIsTheEnd = true;
	}

    IEnumerator FlashSequence ()
    {
        yield return new WaitForSeconds(3f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(1f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(1.5f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(0.5f);
        //Ready up some scary stuff
        yield return new WaitForSeconds(0.5f);
        //CameraFlashScript.Blink();

        //Do alot of scary stuff
    }

    public static void ClockFinished ()
    {
        foreach (GameObject l in MusicBoxScript.lights)
            l.GetComponent<Light>().enabled = false;
        DongScript.allowDongs = false;
        StartFlashing = true;
    }
}
