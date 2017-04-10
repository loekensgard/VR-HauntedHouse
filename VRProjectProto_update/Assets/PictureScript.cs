using System.Collections;
using UnityEngine;

public class PictureScript: MonoBehaviour {
	public GameObject piece1;
	public GameObject piece2;
	public GameObject piece3;
	public GameObject piece4;
	public GameObject piece5;
    public GameObject kamera;
    public GameObject crawlerPref;
    public GameObject crawlerPrefNoDir;
    public GameObject teleporterContainer;
    public GameObject walker;
    public GameObject text;
    public GameObject startText;
    public GameObject manPref;
    public GameObject chairOne;
    public GameObject chairTwo;
    public GameObject pictureLight;
    public GameObject horrorSound;
    public GameObject womanScream;
    public GameObject scaryWomanPref;
    GameObject crawler;
    GameObject crawlerTwo;
    public static bool eventAllowed = true;

    static bool StartFlashing;
    bool endHasStarted;

	int piecesFound;

	// Use this for initialization
	void Start () {
		piece1.GetComponent<Renderer> ().enabled = false;
		piece2.GetComponent<Renderer> ().enabled = false;
		piece3.GetComponent<Renderer> ().enabled = false;
		piece4.GetComponent<Renderer> ().enabled = false;
		piece5.GetComponent<Renderer> ().enabled = false;
        text.GetComponent<Renderer>().enabled = false;
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
        gameObject.GetComponent<AudioSource>().Play();

        if(piecesFound == 5)
        {
            text.GetComponent<Renderer>().enabled = true;
            pictureLight.GetComponent<Light>().enabled = false;
            startText.GetComponent<Renderer>().enabled = false; 
        }
	}


	public void EndSequence () {
        if (!endHasStarted && piecesFound == 5)
        {
            eventAllowed = false;
            endHasStarted = true;
            MoveClockScript.PictureFinishedMove();
            ClockScript.thisIsTheEnd = true;
            DongScript.allowDongs = false;
            teleporterContainer.GetComponent<VRTK.VRTK_BezierPointer>().enabled = false;
        }
	}

    IEnumerator FlashSequence ()
    {
        Destroy(chairOne);
        Destroy(chairTwo);
        horrorSound.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1.5f);
        walker.GetComponent<WalkDownStairScrip>().WalkDownStairs();
        yield return new WaitForSeconds(2.5f);
        kamera.GetComponent<CameraFlashScript>().ChargeFlash();
        yield return new WaitForSeconds(3f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(1f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(1.5f);
        GameObject man = Instantiate(manPref, new Vector3(-0.41f, 0.785f, -2.567818f), Quaternion.identity);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(1f);
        crawler = Instantiate(crawlerPrefNoDir, new Vector3(-5.682f, 3.498f, -4.319f), Quaternion.Euler(30f, 0f, -90f));
        crawler.GetComponent<RunningCrawlScript>().PlaySound();
        crawler.GetComponent<RunningCrawlScript>().RunGirl();
        GameObject manTwo = Instantiate(manPref, new Vector3(-2.64f, 0.785f, -2.096f), Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(2f);
        Destroy(man);
        Destroy(manTwo);
        man = Instantiate(manPref, new Vector3(-2.648f, 0.785f, -0.982f), Quaternion.identity);
        manTwo = Instantiate(manPref, new Vector3(-0.443f, 0.785f, -0.518f), Quaternion.identity);
        crawler = Instantiate(crawlerPrefNoDir, new Vector3(-1.277f, -0.01f, -4.186f), Quaternion.Euler(0f, 80f, 0f));
        crawler.GetComponent<RunningCrawlScript>().PlaySound();
        crawler.GetComponent<RunningCrawlScript>().RunGirl();
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(0.4f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(1.9f);
        Destroy(man);
        Destroy(manTwo);
        man = Instantiate(manPref, new Vector3(-0.607f, 0.785f, -0.432f), Quaternion.identity);
        manTwo = Instantiate(manPref, new Vector3(-1.827114f, 0.785f, -1.228f), Quaternion.identity);
        GameObject manThree = Instantiate(manPref, new Vector3(-2.54495f, 0.785f, 0.04381882f), Quaternion.identity);
        GameObject manFour = Instantiate(manPref, new Vector3(-3.483894f, 0.785f, 1.343f), Quaternion.identity);
        crawler = Instantiate(crawlerPrefNoDir, new Vector3(1.894386f, -0.01f, -2.081249f), Quaternion.Euler(0f, -115f, 0f));
        crawler.GetComponent<RunningCrawlScript>().RunGirl();
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(0.4f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(2f);
        Destroy(man);
        Destroy(manTwo);
        Destroy(manThree);
        Destroy(manFour);
        yield return new WaitForSeconds(0.5f);
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(0.5f);
        crawler = Instantiate(crawlerPref, new Vector3(-2.48f, -0.01f, -4.406f), Quaternion.identity);
        crawler.GetComponent<RunningCrawlScript>().PlaySound();
        yield return new WaitForSeconds(1f);
        crawler.GetComponent<RunningCrawlScript>().RunGirl();
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(2f);
        crawlerTwo = Instantiate(crawlerPref, new Vector3(-2.48f, -0.01f, -2.125769f), Quaternion.identity);
        crawlerTwo.GetComponent<RunningCrawlScript>().RunGirl();
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(4.5f);
        GameObject lastDude = Instantiate(scaryWomanPref, new Vector3(Camera.main.transform.position.x, 0f, Camera.main.transform.position.z - 0.5f), Quaternion.identity);
        womanScream.GetComponent<AudioSource>().volume = 1;
        womanScream.GetComponent<AudioSource>().Play();
        kamera.GetComponent<CameraFlashScript>().Blink();
        yield return new WaitForSeconds(3f);
        Application.Quit();

    }

    public static void ClockFinished ()
    {
        foreach (GameObject l in MusicBoxScript.lights)
            l.GetComponent<Light>().enabled = false;
        StartFlashing = true;
        FogOffScript.FogOff();
    }
}
