using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgrScrooling : MonoBehaviour {



	private Material mate;

	private Vector2 offset = Vector2.zero;

	public float scrollSpeed;

	void Awake(){
		mate = GetComponent<Renderer> ().material;

	}


    // Start is called before the first frame update
    void Start(){
        offset = mate.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update(){
        offset.y += scrollSpeed * Time.deltaTime;
        mate.SetTextureOffset("_MainTex", offset);
    }
}
