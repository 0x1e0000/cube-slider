using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;
	public float forwardForce = 1000f;
	public float sideForce = 600f;
	private bool noCollision = true;

	// Fixed Update is called once per frame (it's better for calculating phiysices)
	void FixedUpdate()
	{
		if (noCollision)
		{
			// Add a forward force on the x-axis
			rb.AddForce(0, 0, forwardForce * Time.deltaTime);

			if (Input.GetKey("d"))
				rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			if (Input.GetKey("a"))
				rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			if (rb.position.y < -1)
				FindObjectOfType<GameManager>().EndGame();
		}
	}

	// It will runs whenever the object collids with something
	void OnCollisionEnter(Collision Info)
	{
		if (Info.collider.tag == "Obstacle")
		{
			noCollision = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
