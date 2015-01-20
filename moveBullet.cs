using UnityEngine;
using System.Collections;

public class moveBullet : MonoBehaviour 
{
	public float speed;
	public float lifeTime = 0f;
    public GameObject explosionPreFab;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float delta = Time.deltaTime;
		transform.Translate (Vector3.forward * speed * delta);
		lifeTime += delta;

		if (lifeTime > 5f) 
		{
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter(Collision coll)
	{
        Instantiate(explosionPreFab, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
	}
}
