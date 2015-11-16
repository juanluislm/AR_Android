using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {
	
	

	public AudioClip clip;
	private TrackableBehaviour mTrackableBehavior;
	// Use this for initialization
	void Start () {
		mTrackableBehavior = GetComponent<TrackableBehaviour>();
		Update();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(mTrackableBehavior){
			audio.Play();
			
		}
		/*if(mTrackableBehavior){
			Renderer[] rendererComponents = GetComponentsInChildren<Renderer>();

        // Enable rendering:
        	foreach (Renderer component in rendererComponents) {
          	  component.enabled = true;
       		 }
			radioActual += incrementoRadioPorSegundo * Time.deltaTime;
			
			transform.position = new Vector3 (objetoCentroDeRotacion.position.x, transform.position.y, objetoCentroDeRotacion.position.z);
			transform.Translate (-radioActual, 0, 0);
			
			transform.RotateAround (objetoCentroDeRotacion.position, Vector3.up, rotacionPorSegundo * Time.deltaTime);
		}else{
			Renderer[] rendererComponents = GetComponentsInChildren<Renderer>();

        // Enable rendering:
        	foreach (Renderer component in rendererComponents) {
            	component.enabled = false;
        	}
		}*/
	}
}
