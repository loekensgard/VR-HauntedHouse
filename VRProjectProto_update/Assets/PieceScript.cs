using UnityEngine;
using System.Collections;

public class PieceScript : MonoBehaviour {

	public GameObject picture;

    public int piece;

	public void PieceFound ()
	{
        StartCoroutine(PieceFoundEvent());
	}

    IEnumerator PieceFoundEvent ()
    {
        gameObject.GetComponent<VRTK.VRTK_InteractableObject>().isUsable = false;
        gameObject.GetComponent<ParticleSystem>().Play();
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.7f);
        picture.GetComponent<PictureScript>().FindPiece(piece);
        gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1.8f);
        Destroy(gameObject);
    }
}
