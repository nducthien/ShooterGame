using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    // Start is called before the first frame update

	public float planeSpeed;

	private Rigidbody2D myBody;

    [SerializeField]
    private GameObject bullet;

    private bool canShoot = true;

	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
	}

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate(){
        PlaneMovement();
    }

    void Update(){
        if(Input.GetKey(KeyCode.Space)){
            if(canShoot){
                StartCoroutine (Shoot());
            }
        }
    }

    // di chuyen vong quanh bgr
    void PlaneMovement(){
    	float xAxis = Input.GetAxisRaw("Horizontal") * planeSpeed;
    	float yAxis = Input.GetAxisRaw("Vertical") * planeSpeed;
    	myBody.velocity = new Vector2(xAxis,yAxis);
    }

    // de deley mot thang nao do su dung ham
    IEnumerator Shoot(){
        canShoot = false;

        //Vien dan ban tu dau may bay
        Vector3 temp = transform.position;
        temp.y += 0.6f;


        Instantiate(bullet, temp, Quaternion.identity);

        yield return new WaitForSeconds (0.2f);


        canShoot = true;
        

    }
}
