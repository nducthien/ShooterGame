using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
   
	public float speed;

	private Rigidbody2D myBody;

	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
	}

    void Start()
    {
        
    }

    // de di chuyen doi tuong co vat li viet code trong ham Fixupdate 
    void FixedUpdate(){
    	myBody.velocity = new Vector2(0f, speed );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.tag == "Border")
        {
            Destroy(gameObject);
        }
    }


}
