using UnityEngine;

public class PictureScript: MonoBehaviour {
	public GameObject piece1;
	public GameObject piece2;
	public GameObject piece3;
	public GameObject piece4;
	public GameObject piece5;

	int piecesFound;

	// Use this for initialization
	void Start () {
		piece1.GetComponent<Renderer> ().enabled = false;
		piece2.GetComponent<Renderer> ().enabled = false;
		piece3.GetComponent<Renderer> ().enabled = false;
		piece4.GetComponent<Renderer> ().enabled = false;
		piece5.GetComponent<Renderer> ().enabled = false;
		piecesFound = 0;
		PieceOneSequence ();
	}
	
	public void FindPiece (int piece)
	{
		piecesFound++;
        switch (piece)
        {
            case 1:
                piece1.GetComponent<Renderer>().enabled = true;
                PieceTwoSequence();
                if (piecesFound == 5)
                    EndSequence();
                break;
            case 2:
                piece2.GetComponent<Renderer>().enabled = true;
                PieceThreeSequence();
                if (piecesFound == 5)
                    EndSequence();
                break;
            case 3:
                piece3.GetComponent<Renderer>().enabled = true;
                PieceFourSequence();
                if (piecesFound == 5)
                    EndSequence();
                break;
            case 4:
                piece4.GetComponent<Renderer>().enabled = true;
                PieceFiveSequence();
                if (piecesFound == 5)
                    EndSequence();
                break;
            case 5:
                piece5.GetComponent<Renderer>().enabled = true;
                if (piecesFound == 5)
                    EndSequence();
                break;
            default:
                break;
        }
        gameObject.GetComponent<AudioSource>().Play();
	}


	//TODO: For hver sekvens, plasser ut bilde som skal finnes, og tillat hint og animasjoner tilhørende den bildebiten.

	void PieceOneSequence () {
	}

	void PieceTwoSequence () {
	}

	void PieceThreeSequence () {
	}

	void PieceFourSequence () {
	}

	void PieceFiveSequence () {
	}

	void EndSequence () {
        MoveClockScript.PictureFinishedMove();
	}
}
