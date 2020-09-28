using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public Transform player;
	public Text scoreText;
	// Update is called once per frame
	void Update()
	{
		float score = player.position.z / 10;
		scoreText.text = score.ToString("0");
	}
}
