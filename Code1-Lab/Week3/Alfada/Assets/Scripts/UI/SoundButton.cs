using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SoundButton : MonoBehaviour, IPointerEnterHandler {


	public AudioClip[] audioClip;


	public virtual void OnPointerEnter(PointerEventData eventData){

		PlaySound (0);


	}



	//public virtual void OnPointerClick(PointerEventData eventData){

	//	PlaySound (1);
		//Debug.Log ("Click");
	//}
		

	public void PlaySound(int clip){


		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = audioClip [clip];
		audio.Play ();

	}



	

}
