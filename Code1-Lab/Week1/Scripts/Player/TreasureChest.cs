using UnityEngine;
using System.Collections;

public class TreasureChest : MonoBehaviour {

	public AudioSource Open;
	public AudioSource Item;
	public GameObject Axe;
	public Animator chestOpen;
	public int distanceToItem;
	public bool gotItem;

	// Use this for initialization
	void Start () {

		gotItem = false;
	}
	
	// Update is called once per frame
	void Update () {
	

		OpenChest ();



	}



	IEnumerator GatherAxe(){
		yield return new WaitForSeconds (3);
		Axe.SetActive (true);
		Item.Play ();

	}

	void OpenChest(){

		if(Input.GetKeyDown(KeyCode.E)){

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit, distanceToItem)) {

				if (hit.collider.gameObject.name == "Chest") {

					chestOpen.SetBool ("Open", true);
					gotItem = true;
					StartCoroutine (GatherAxe ());
					Open.Play ();


				}
			}
		}

	}

}
