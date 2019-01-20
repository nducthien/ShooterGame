using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{

	public float enemySpeed;

	private Rigidbody2D myBody;

    [SerializeField]
    private GameObject bullet ;

    void Start(){
        StartCoroutine(EnemyShoot());

    }

    void Awake(){
        myBody = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate(){
        myBody.velocity = new Vector2(0f, -enemySpeed);
    }

    IEnumerator EnemyShoot(){
        yield return new WaitForSeconds (Random.Range(1f,3f));

        Vector3 temp = transform.position;
        temp.y -= 0.6f;
        Instantiate(bullet, temp, Quaternion.identity);

        StartCoroutine(EnemyShoot());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            GamePlayController.instance.PlaneDiedShowPanel();
        }

        if(collision.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
