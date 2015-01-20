using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {

    public int lifes = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        print("what hit me " + coll.gameObject.name);
        if(coll.gameObject.name == "bullet(Clone)")
        {
            lifes--;
            if (lifes <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
