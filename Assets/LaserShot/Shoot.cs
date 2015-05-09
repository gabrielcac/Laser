using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Vector3 localShootStart;
	public GameObject laserPrefab;
	public GameObject world;
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown)
		{
			ShootLaser();
		}
	}

	private void ShootLaser()
	{
		GameObject laser = (GameObject) GameObject.Instantiate(laserPrefab);
		laser.transform.position = transform.localToWorldMatrix * localShootStart;
		laser.GetComponent<SpringJoint>().connectedBody = world.rigidbody;
		laser.rigidbody.velocity = transform.rotation * (10f * Vector3.forward);
	}
}
